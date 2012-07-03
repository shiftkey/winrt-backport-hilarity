using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class RenderingEventArgs : IRenderingEventArgs
	{
		public extern TimeSpan RenderingTime
		{
			get;
		}
	}
}
