using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;

namespace WpfTestBed
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {
            ComWrappers.RegisterForMarshalling(WinFormsComInterop.WinFormsComWrappers.Instance);
        }
    }
}
