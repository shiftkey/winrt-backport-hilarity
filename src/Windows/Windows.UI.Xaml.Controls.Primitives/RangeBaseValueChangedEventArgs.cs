using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class RangeBaseValueChangedEventArgs : RoutedEventArgs, IRangeBaseValueChangedEventArgs
	{
		public extern double NewValue
		{
			get;
		}
		public extern double OldValue
		{
			get;
		}
	}
}
