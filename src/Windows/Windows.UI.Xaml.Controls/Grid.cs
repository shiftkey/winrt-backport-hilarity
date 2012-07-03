using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(IGridFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IGridStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class Grid : Panel, IGrid
	{
		public extern ColumnDefinitionCollection ColumnDefinitions
		{
			get;
		}
		public extern RowDefinitionCollection RowDefinitions
		{
			get;
		}
		public static extern DependencyProperty ColumnProperty
		{
			get;
		}
		public static extern DependencyProperty ColumnSpanProperty
		{
			get;
		}
		public static extern DependencyProperty RowProperty
		{
			get;
		}
		public static extern DependencyProperty RowSpanProperty
		{
			get;
		}
		public extern Grid();
		public static extern int GetRow([In] FrameworkElement element);
		public static extern void SetRow([In] FrameworkElement element, [In] int value);
		public static extern int GetColumn([In] FrameworkElement element);
		public static extern void SetColumn([In] FrameworkElement element, [In] int value);
		public static extern int GetRowSpan([In] FrameworkElement element);
		public static extern void SetRowSpan([In] FrameworkElement element, [In] int value);
		public static extern int GetColumnSpan([In] FrameworkElement element);
		public static extern void SetColumnSpan([In] FrameworkElement element, [In] int value);
	}
}
