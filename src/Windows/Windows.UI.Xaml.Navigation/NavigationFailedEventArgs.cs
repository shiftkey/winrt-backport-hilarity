using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
namespace Windows.UI.Xaml.Navigation
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class NavigationFailedEventArgs : INavigationFailedEventArgs
	{
		public extern HResult Exception
		{
			get;
		}
		public extern bool Handled
		{
			get;
			set;
		}
		public extern TypeName SourcePageType
		{
			get;
		}
	}
}
