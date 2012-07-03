using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ContentPresenter)), Guid(415402299u, 55854, 17446, 184, 90, 44, 126, 33, 113, 190, 223), Version(100794368u), WebHostHidden]
	internal interface IContentPresenterStatics
	{
		DependencyProperty CharacterSpacingProperty
		{
			get;
		}
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
		DependencyProperty FontFamilyProperty
		{
			get;
		}
		DependencyProperty FontSizeProperty
		{
			get;
		}
		DependencyProperty FontStretchProperty
		{
			get;
		}
		DependencyProperty FontStyleProperty
		{
			get;
		}
		DependencyProperty FontWeightProperty
		{
			get;
		}
		DependencyProperty ForegroundProperty
		{
			get;
		}
	}
}
