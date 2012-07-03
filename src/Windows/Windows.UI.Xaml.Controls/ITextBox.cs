using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(TextBox)), Guid(3834600075u, 7679, 17234, 161, 244, 229, 22, 81, 78, 200, 130), Version(100794368u), WebHostHidden]
	internal interface ITextBox
	{
		event ContextMenuOpeningEventHandler ContextMenuOpening;
		event RoutedEventHandler SelectionChanged;
		event TextChangedEventHandler TextChanged;
		bool AcceptsReturn
		{
			get;
			set;
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
		int MaxLength
		{
			get;
			set;
		}
		string SelectedText
		{
			get;
			set;
		}
		int SelectionLength
		{
			get;
			set;
		}
		int SelectionStart
		{
			get;
			set;
		}
		string Text
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
		void Select([In] int start, [In] int length);
		void SelectAll();
		Rect GetRectFromCharacterIndex([In] int charIndex, [In] bool trailingEdge);
	}
}
