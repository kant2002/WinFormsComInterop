[assembly: global::System.Runtime.CompilerServices.IgnoresAccessChecksTo("System.Windows.Forms.Primitives")]
[assembly: global::System.Runtime.CompilerServices.IgnoresAccessChecksTo("System.Drawing.Common")]
[assembly: global::System.Runtime.CompilerServices.IgnoresAccessChecksTo("WindowsBase")]

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
