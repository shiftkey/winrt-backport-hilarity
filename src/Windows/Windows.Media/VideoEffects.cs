using System;
using Windows.Foundation.Metadata;
namespace Windows.Media
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IVideoEffectsStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public static class VideoEffects
	{
		public static extern string VideoStabilization
		{
			get;
		}
	}
}
