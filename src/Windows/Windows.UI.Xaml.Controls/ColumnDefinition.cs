using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IColumnDefinitionStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ColumnDefinition : DependencyObject, IColumnDefinition
	{
		public extern double ActualWidth
		{
			get;
		}
		public extern double MaxWidth
		{
			get;
			set;
		}
		public extern double MinWidth
		{
			get;
			set;
		}
		public extern GridLength Width
		{
			get;
			set;
		}
		public static extern DependencyProperty MaxWidthProperty
		{
			get;
		}
		public static extern DependencyProperty MinWidthProperty
		{
			get;
		}
		public static extern DependencyProperty WidthProperty
		{
			get;
		}
		public extern ColumnDefinition();
	}
}
