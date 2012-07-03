using System;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Input;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(IRichEditBoxFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IRichEditBoxStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class RichEditBox : Control, IRichEditBox
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
		public extern event RoutedEventHandler TextChanged
		{
			add;
			remove;
		}
		public extern bool AcceptsReturn
		{
			get;
			set;
		}
		public extern ITextDocument Document
		{
			get;
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
		public static extern DependencyProperty TextAlignmentProperty
		{
			get;
		}
		public static extern DependencyProperty TextWrappingProperty
		{
			get;
		}
		public extern RichEditBox();
	}
}
