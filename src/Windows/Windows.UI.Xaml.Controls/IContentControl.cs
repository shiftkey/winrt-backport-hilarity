using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ContentControl)), Guid(2725106140u, 52548, 17244, 190, 148, 1, 214, 36, 28, 35, 28), Version(100794368u), WebHostHidden]
	internal interface IContentControl
	{
		object Content
		{
			get;
			set;
		}
		DataTemplate ContentTemplate
		{
			get;
			set;
		}
		DataTemplateSelector ContentTemplateSelector
		{
			get;
			set;
		}
		TransitionCollection ContentTransitions
		{
			get;
			set;
		}
	}
}
