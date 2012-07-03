using System;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ContentPresenter)), Guid(2046682548u, 52535, 18716, 136, 69, 218, 244, 114, 222, 255, 246), Version(100794368u), WebHostHidden]
	internal interface IContentPresenter
	{
		int CharacterSpacing
		{
			get;
			set;
		}
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
		FontFamily FontFamily
		{
			get;
			set;
		}
		double FontSize
		{
			get;
			set;
		}
		FontStretch FontStretch
		{
			get;
			set;
		}
		FontStyle FontStyle
		{
			get;
			set;
		}
		FontWeight FontWeight
		{
			get;
			set;
		}
		Brush Foreground
		{
			get;
			set;
		}
	}
}
