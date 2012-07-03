using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(ITextBoxFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ITextBoxStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class TextBox : Control, ITextBox
	{
		public extern event ContextMenuOpeningEventHandler ContextMenuOpening
		{
			add;
			remove;
		}
		public extern event RoutedEventHandler SelectionChanged
		{
			add;
			remove;
		}
		public extern event TextChangedEventHandler TextChanged
		{
			add;
			remove;
		}
		public extern bool AcceptsReturn
		{
			get;
			set;
		}
		public extern InputScope InputScope
		{
			get;
			set;
		}
		public extern bool IsReadOnly
		{
			get;
			set;
		}
		public extern bool IsSpellCheckEnabled
		{
			get;
			set;
		}
		public extern bool IsTextPredictionEnabled
		{
			get;
			set;
		}
		public extern int MaxLength
		{
			get;
			set;
		}
		public extern string SelectedText
		{
			get;
			set;
		}
		public extern int SelectionLength
		{
			get;
			set;
		}
		public extern int SelectionStart
		{
			get;
			set;
		}
		public extern string Text
		{
			get;
			set;
		}
		public extern TextAlignment TextAlignment
		{
			get;
			set;
		}
		public extern TextWrapping TextWrapping
		{
			get;
			set;
		}
		public static extern DependencyProperty AcceptsReturnProperty
		{
			get;
		}
		public static extern DependencyProperty InputScopeProperty
		{
			get;
		}
		public static extern DependencyProperty IsReadOnlyProperty
		{
			get;
		}
		public static extern DependencyProperty IsSpellCheckEnabledProperty
		{
			get;
		}
		public static extern DependencyProperty IsTextPredictionEnabledProperty
		{
			get;
		}
		public static extern DependencyProperty MaxLengthProperty
		{
			get;
		}
		public static extern DependencyProperty TextAlignmentProperty
		{
			get;
		}
		public static extern DependencyProperty TextProperty
		{
			get;
		}
		public static extern DependencyProperty TextWrappingProperty
		{
			get;
		}
		public extern TextBox();
		public extern void Select([In] int start, [In] int length);
		public extern void SelectAll();
		public extern Rect GetRectFromCharacterIndex([In] int charIndex, [In] bool trailingEdge);
	}
}
