using System.Runtime.InteropServices;

namespace WinFormsComInterop.SourceGenerator
{
    internal class MarshalDescriptor
    {
        public MarshalDescriptor(UnmanagedType? unmanagedType, short arrayIndex)
        {
            UnmanagedType = unmanagedType;
            ArrayIndex = arrayIndex;
        }

        public UnmanagedType? UnmanagedType { get; }
        public short ArrayIndex { get; }
    }
}
