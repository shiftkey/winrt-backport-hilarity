using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Markup
{
	[AttributeUsage(AttributeTargets.RuntimeClass), Version(100794368u), WebHostHidden]
	public sealed class ContentPropertyAttribute : Attribute
	{
		public string Name;
		public extern ContentPropertyAttribute();
	}
}
