using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[AllowMultiple, AttributeUsage(AttributeTargets.RuntimeClass), Version(100794368u), WebHostHidden]
	public sealed class StyleTypedPropertyAttribute : Attribute
	{
		public string Property;
		public Type StyleTargetType;
		public extern StyleTypedPropertyAttribute();
	}
}
