using System;
namespace Windows.Foundation.Metadata
{
	//[AllowMultiple, AttributeUsage(AttributeTargets.RuntimeClass), Version(100794368u)]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public sealed class ComposableAttribute : Attribute
	{
		public extern ComposableAttribute(Type type, CompositionType compositionType, uint version);
	}
}
