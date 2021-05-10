using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
#if NETCOREAPP5_0
    
#endif

    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Reflection trick does not helps too much.
#if NET472
            var field = typeof(Control.ControlAccessibleObject)
                .GetField("s_oleAccAvailable",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
            field.SetValue(null, IntPtr.Zero);
#else
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            var field = typeof(Control.ControlAccessibleObject)
                .GetField("s_oleAccAvailable",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
            //field.SetValue(null, IntPtr.Zero);
#endif
            ComWrappers.RegisterForMarshalling(WinFormsComInterop.WinFormsComWrappers.Instance);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
