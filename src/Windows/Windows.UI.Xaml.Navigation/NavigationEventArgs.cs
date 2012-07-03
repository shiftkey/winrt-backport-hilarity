using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
namespace Windows.UI.Xaml.Navigation
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class NavigationEventArgs : INavigationEventArgs
	{
		public extern object Content
		{
			get;
		}
		public extern NavigationMode NavigationMode
		{
			get;
		}
		public extern object Parameter
		{
			get;
		}
		public extern TypeName SourcePageType
		{
			get;
		}
		public extern Uri Uri
		{
			get;
			set;
		}
	}
}
