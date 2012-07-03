using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(RichEditBox)), Guid(4125112948u, 35050, 18331, 154, 5, 55, 8, 159, 243, 14, 222), Version(100794368u), WebHostHidden]
	internal interface IRichEditBoxStatics
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
		DependencyProperty TextAlignmentProperty
		{
			get;
		}
		DependencyProperty TextWrappingProperty
		{
			get;
		}
	}
}
