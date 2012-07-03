using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.MediaProperties
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class AudioEncodingProperties : IAudioEncodingProperties, IMediaEncodingProperties
	{
		public extern uint Bitrate
		{
			get;
			set;
		}
		public extern uint BitsPerSample
		{
			get;
			set;
		}
		public extern uint ChannelCount
		{
			get;
			set;
		}
		public extern uint SampleRate
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
		public extern AudioEncodingProperties();
	}
}
