using System;
namespace Windows.Foundation.Metadata
{
	//[AttributeUsage(AttributeTargets.RuntimeClass), Version(100794368u)]
    [AttributeUsage(AttributeTargets.Class)] 
	public sealed class GCPressureAttribute : Attribute
	{
		public GCPressureAmount amount;
		public extern GCPressureAttribute();
	}
}
