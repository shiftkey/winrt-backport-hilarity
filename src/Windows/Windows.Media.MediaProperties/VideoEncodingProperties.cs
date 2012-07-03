using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.MediaProperties
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class VideoEncodingProperties : IVideoEncodingProperties, IMediaEncodingProperties
	{
		public extern uint Bitrate
		{
			get;
			set;
		}
		public extern MediaRatio FrameRate
		{
			get;
		}
		public extern uint Height
		{
			get;
			set;
		}
		public extern MediaRatio PixelAspectRatio
		{
			get;
		}
		public extern uint Width
		{
			get;
			set;
		}
		public extern MediaPropertySet Properties
		{
			get;
		}
		public extern string Subtype
		{
			get;
			set;
		}
		public extern string Type
		{
			get;
		}
		public extern VideoEncodingProperties();
	}
}
