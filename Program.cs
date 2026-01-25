using System.Diagnostics;

namespace SIF.Utils
{
    using SIF.Utils.Forms.Main;

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// <param name="args"></param>
        [STAThread]
        static void Main(string[]? args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            GlobalMouseHandler globalClick = new GlobalMouseHandler();
            Application.AddMessageFilter(globalClick);
            Application.Run(new SifJsonParsingForm(args));
        }
    }
    public class GlobalMouseHandler : IMessageFilter
    {
        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 256)
            {
                if (m.WParam == 166)
                {
                    GoBack();
                    return true;
                }
            }

            return false;
        }

        public void GoBack()
        {
            // Get the active form
            var activeForm = Form.ActiveForm;

            // Use the activeForm object as needed
            if (activeForm is SifJsonParsingForm form)
            {
                form.NavigateBack();
            }

            if (activeForm is JsonViewer viewer)
            {
                viewer.Close();
            }
        }
    }
}