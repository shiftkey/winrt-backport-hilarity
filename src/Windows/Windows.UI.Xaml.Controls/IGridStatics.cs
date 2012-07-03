using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Grid)), Guid(1694379679u, 63825, 17078, 169, 206, 187, 23, 154, 241, 21, 149), Version(100794368u), WebHostHidden]
	internal interface IGridStatics
	{
		DependencyProperty ColumnProperty
		{
			get;
		}
		DependencyProperty ColumnSpanProperty
		{
			get;
		}
		DependencyProperty RowProperty
		{
			get;
		}
		DependencyProperty RowSpanProperty
		{
			get;
		}
		int GetRow([In] FrameworkElement element);
		void SetRow([In] FrameworkElement element, [In] int value);
		int GetColumn([In] FrameworkElement element);
		void SetColumn([In] FrameworkElement element, [In] int value);
		int GetRowSpan([In] FrameworkElement element);
		void SetRowSpan([In] FrameworkElement element, [In] int value);
		int GetColumnSpan([In] FrameworkElement element);
		void SetColumnSpan([In] FrameworkElement element, [In] int value);
	}
}
