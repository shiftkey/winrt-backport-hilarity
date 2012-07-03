using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.MediaProperties
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class ContainerEncodingProperties : IContainerEncodingProperties, IMediaEncodingProperties
	{
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
		public extern ContainerEncodingProperties();
	}
}
