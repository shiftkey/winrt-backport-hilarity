using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.MediaProperties
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class MediaRatio : IMediaRatio
	{
		public extern uint Denominator
		{
			get;
			set;
		}
		public extern uint Numerator
		{
			get;
			set;
		}
	}
}
