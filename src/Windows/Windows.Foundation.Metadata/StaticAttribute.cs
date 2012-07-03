using System;
namespace Windows.Foundation.Metadata
{
	//[AllowMultiple, AttributeUsage(AttributeTargets.RuntimeClass), Version(100794368u)]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public sealed class StaticAttribute : Attribute
	{
		public extern StaticAttribute(Type type, uint version);
	}
}
