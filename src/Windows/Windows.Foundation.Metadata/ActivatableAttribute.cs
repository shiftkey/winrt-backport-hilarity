using System;
namespace Windows.Foundation.Metadata
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class ActivatableAttribute : Attribute
    {
        public extern ActivatableAttribute(uint version);
        public extern ActivatableAttribute(Type type, uint version);
    }
}
