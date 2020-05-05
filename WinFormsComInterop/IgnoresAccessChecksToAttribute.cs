[assembly: System.Runtime.CompilerServices.IgnoresAccessChecksToAttribute("System.Windows.Forms.Primitives")]

namespace System.Runtime.CompilerServices
{
    public class IgnoresAccessChecksToAttribute: Attribute
    {
        public IgnoresAccessChecksToAttribute(string assemblyName)
        {
            this.AssemblyName = assemblyName;
        }

        public string AssemblyName { get; }
    }
}
