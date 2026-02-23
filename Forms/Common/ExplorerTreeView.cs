namespace SIF.Utils.Forms.Common;

using System.Runtime.InteropServices;

public class ExplorerTreeView : TreeView
{

    [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
    private static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);

    public ExplorerTreeView()
    {
        SetWindowTheme(this.Handle, "explorer", null);
    }
}