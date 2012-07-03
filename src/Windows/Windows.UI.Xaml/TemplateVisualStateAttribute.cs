using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[AllowMultiple, AttributeUsage(AttributeTargets.RuntimeClass), Version(100794368u), WebHostHidden]
	public sealed class TemplateVisualStateAttribute : Attribute
	{
		public string Name;
		public string GroupName;
		public extern TemplateVisualStateAttribute();
	}
}
