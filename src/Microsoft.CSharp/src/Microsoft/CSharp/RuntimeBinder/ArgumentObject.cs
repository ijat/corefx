using System;

namespace Microsoft.CSharp.RuntimeBinder
{
    // This struct is used to keep the tuple of runtime object values and 
    // the type that we want to use for the argument. This is different than the runtime
    // value's type because unless the static time type was dynamic, we want to use the
    // static time type. Also, we may have null values, in which case we would not be 
    // able to get the type.
    internal readonly struct ArgumentObject
    {
        internal readonly object Value;
        internal readonly CSharpArgumentInfo Info;
        internal readonly Type Type;

        public ArgumentObject(object value, CSharpArgumentInfo info, Type type)
        {
            Value = value;
            Info = info;
            Type = type;
        }
    }
}