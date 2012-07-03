using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[Version(100794368u), WebHostHidden]
	public struct Duration
	{
		public TimeSpan TimeSpan;
		public DurationType Type;
	}
}
