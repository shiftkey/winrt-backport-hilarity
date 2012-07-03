using System;
namespace Windows.Foundation.Metadata
{
	//[AttributeUsage(AttributeTargets.InterfaceImpl), Version(100794368u)]
    [AttributeUsage(AttributeTargets.Class)]
	public sealed class DefaultAttribute : Attribute
	{
		public extern DefaultAttribute();
	}
}
