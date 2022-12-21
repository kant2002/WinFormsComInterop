[assembly: global::System.Runtime.CompilerServices.IgnoresAccessChecksTo("System.Windows.Forms")]
[assembly: global::System.Runtime.CompilerServices.IgnoresAccessChecksTo("System.Windows.Forms.Primitives")]
[assembly: global::System.Runtime.CompilerServices.IgnoresAccessChecksTo("System.Drawing.Common")]
[assembly: global::System.Runtime.CompilerServices.IgnoresAccessChecksTo("WindowsBase")]
[assembly: global::System.Runtime.CompilerServices.IgnoresAccessChecksTo("PresentationCore")]
[assembly: global::System.Runtime.CompilerServices.IgnoresAccessChecksTo("Microsoft.Web.WebView2.Core")]

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
    public class IgnoresAccessChecksToAttribute: Attribute
    {
        public IgnoresAccessChecksToAttribute(string assemblyName)
        {
            this.AssemblyName = assemblyName;
        }

        public string AssemblyName { get; }
    }
}
