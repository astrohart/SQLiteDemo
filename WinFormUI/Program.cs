using System;
using System.Windows.Forms;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Diagnostics.Backends.Trace;

namespace WinFormUI
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Add logging support
            LoggingServices.DefaultBackend = new TraceLoggingBackend();

            Application.Run(MainWindow.Instance);
        }
    }
}