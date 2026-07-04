using System.ComponentModel;
using System.Diagnostics;
using System.Security.Principal;

namespace SIF.Utils.Logic.AdminMode;

public interface IAdminModeApi
{
    bool IsRunningAsAdministrator();
    bool RestartAsAdministrator();
}

public class AdminModeApi : IAdminModeApi
{
    private const int ErrorCancelled = 1223;

    public bool IsRunningAsAdministrator()
    {
        using var identity = WindowsIdentity.GetCurrent();
        var principal = new WindowsPrincipal(identity);
        return principal.IsInRole(WindowsBuiltInRole.Administrator);
    }

    public bool RestartAsAdministrator()
    {
        if (IsRunningAsAdministrator())
        {
            return true;
        }

        var exePath = Environment.ProcessPath ?? Process.GetCurrentProcess().MainModule?.FileName;
        if (string.IsNullOrEmpty(exePath))
        {
            throw new InvalidOperationException("Unable to determine the application executable path.");
        }

        var arguments = Environment.GetCommandLineArgs().Skip(1).Select(a => $"\"{a}\"");
        var startInfo = new ProcessStartInfo(exePath)
        {
            UseShellExecute = true,
            Verb = "runas",
            Arguments = string.Join(" ", arguments)
        };

        try
        {
            Process.Start(startInfo);
        }
        catch (Win32Exception ex) when (ex.NativeErrorCode == ErrorCancelled)
        {
            // The user declined the UAC elevation prompt.
            return false;
        }

        Environment.Exit(0);
        return true;
    }
}
