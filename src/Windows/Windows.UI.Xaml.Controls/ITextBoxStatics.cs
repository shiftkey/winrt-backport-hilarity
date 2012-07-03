using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(TextBox)), Guid(2117596411u, 42172, 17957, 136, 56, 142, 178, 169, 9, 18, 131), Version(100794368u), WebHostHidden]
	internal interface ITextBoxStatics
	{
		DependencyProperty AcceptsReturnProperty
		{
			get;
		}
		DependencyProperty InputScopeProperty
		{
			get;
		}
		DependencyProperty IsReadOnlyProperty
		{
			get;
		}
		DependencyProperty IsSpellCheckEnabledProperty
		{
			get;
		}
		DependencyProperty IsTextPredictionEnabledProperty
		{
			get;
		}
		DependencyProperty MaxLengthProperty
		{
			get;
		}
		DependencyProperty TextAlignmentProperty
		{
			get;
		}
		DependencyProperty TextProperty
		{
			get;
		}
		DependencyProperty TextWrappingProperty
		{
			get;
		}
	}
}
