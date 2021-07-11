namespace System.Runtime.InteropServices
{
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.ReturnValue, Inherited = false)]
    public sealed partial class CustomMarshalAsAttribute : Attribute
    {
        public CustomMarshalAsAttribute(UnmanagedType unmanagedType)
        {
            Value = unmanagedType;
        }
        public CustomMarshalAsAttribute(short unmanagedType)
        {
            Value = (UnmanagedType)unmanagedType;
        }

        public UnmanagedType Value { get; }

        // Fields used with SubType = SafeArray.
        public VarEnum SafeArraySubType;
        public Type? SafeArrayUserDefinedSubType;

        // Field used with iid_is attribute (interface pointers).
        public int IidParameterIndex;

        // Fields used with SubType = ByValArray and LPArray.
        // Array size =  parameter(PI) * PM + C
        public UnmanagedType ArraySubType;
        public short SizeParamIndex;           // param index PI
        public int SizeConst;                // constant C

        // Fields used with SubType = CustomMarshaler
        public string? MarshalType;              // Name of marshaler class
        public Type? MarshalTypeRef;           // Type of marshaler class
        public string? MarshalCookie;            // cookie to pass to marshaler
    }
}