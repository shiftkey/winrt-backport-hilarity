using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.MediaProperties
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IImageEncodingPropertiesStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class ImageEncodingProperties : IImageEncodingProperties, IMediaEncodingProperties
	{
		public extern uint Height
		{
			get;
			set;
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
		public extern ImageEncodingProperties();
		public static extern ImageEncodingProperties CreateJpeg();
		public static extern ImageEncodingProperties CreatePng();
		public static extern ImageEncodingProperties CreateJpegXR();
	}
}
