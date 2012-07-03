using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ContentControl)), Guid(292127396u, 23797, 19461, 165, 63, 21, 228, 135, 108, 133, 236), Version(100794368u), WebHostHidden]
	internal interface IContentControlStatics
	{
		DependencyProperty ContentProperty
		{
			get;
		}
		DependencyProperty ContentTemplateProperty
		{
			get;
		}
		DependencyProperty ContentTemplateSelectorProperty
		{
			get;
		}
		DependencyProperty ContentTransitionsProperty
		{
			get;
		}
	}
}
