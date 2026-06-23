namespace SIF.Utils.Forms.Common
{
    public static class AppVersion
    {
        public static string CurrentVersion { get; }

        static AppVersion()
        {
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            if (version != null)
            {
                CurrentVersion = $"{version.Major}.{version.Minor}";
            }
        }
    }
}
