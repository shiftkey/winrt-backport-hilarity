using System;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Input;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(RichEditBox)), Guid(2426763840u, 32950, 20430, 177, 236, 227, 198, 22, 40, 75, 106), Version(100794368u), WebHostHidden]
	internal interface IRichEditBox
	{
		event ContextMenuOpeningEventHandler ContextMenuOpening;
		event RoutedEventHandler SelectionChanged;
		event RoutedEventHandler TextChanged;
		bool AcceptsReturn
		{
			get;
			set;
		}
		ITextDocument Document
		{
			get;
		}
		InputScope InputScope
		{
			get;
			set;
		}
		bool IsReadOnly
		{
			get;
			set;
		}
		bool IsSpellCheckEnabled
		{
			get;
			set;
		}
		bool IsTextPredictionEnabled
		{
			get;
			set;
		}
		TextAlignment TextAlignment
		{
			get;
			set;
		}
		TextWrapping TextWrapping
		{
			get;
			set;
		}
	}
}
