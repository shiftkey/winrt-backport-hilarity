using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IKeyTimeHelperStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class KeyTimeHelper : IKeyTimeHelper
	{
		public static extern KeyTime FromTimeSpan([In] TimeSpan timeSpan);
	}
}
