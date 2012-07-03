using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[AllowMultiple, AttributeUsage(AttributeTargets.RuntimeClass), Version(100794368u), WebHostHidden]
	public sealed class TemplatePartAttribute : Attribute
	{
		public string Name;
		public Type Type;
		public extern TemplatePartAttribute();
	}
}
