using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Documents
{
	[ExclusiveTo(typeof(TextElement)), Guid(170892184u, 27651, 17520, 167, 155, 50, 152, 161, 4, 130, 206), Version(100794368u), WebHostHidden]
	internal interface ITextElementStatics
	{
		DependencyProperty CharacterSpacingProperty
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
		DependencyProperty LanguageProperty
		{
			get;
		}
	}
}
