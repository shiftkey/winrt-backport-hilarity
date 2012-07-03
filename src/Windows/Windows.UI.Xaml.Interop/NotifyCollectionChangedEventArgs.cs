using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Interop
{
	[Composable(typeof(INotifyCollectionChangedEventArgsFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class NotifyCollectionChangedEventArgs : INotifyCollectionChangedEventArgs
	{
		public extern NotifyCollectionChangedAction Action
		{
			get;
		}
		public extern IBindableVector NewItems
		{
			get;
		}
		public extern int NewStartingIndex
		{
			get;
		}
		public extern IBindableVector OldItems
		{
			get;
		}
		public extern int OldStartingIndex
		{
			get;
		}
		public extern NotifyCollectionChangedEventArgs([In] NotifyCollectionChangedAction action, [In] IBindableVector newItems, [In] IBindableVector oldItems, [In] int newIndex, [In] int oldIndex);
	}
}
