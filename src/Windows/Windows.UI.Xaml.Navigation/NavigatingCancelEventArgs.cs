using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
namespace Windows.UI.Xaml.Navigation
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class NavigatingCancelEventArgs : INavigatingCancelEventArgs
	{
		public extern bool Cancel
		{
			get;
			set;
		}
		public extern NavigationMode NavigationMode
		{
			get;
		}
		public extern TypeName SourcePageType
		{
			get;
		}
	}
}
