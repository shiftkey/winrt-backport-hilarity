using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.MediaProperties
{
	[Guid(3019909878u, 44244, 20058, 162, 75, 93, 116, 152, 168, 184, 196), Version(100794368u)]
	public interface IMediaEncodingProperties
	{
		MediaPropertySet Properties
		{
			get;
		}
		string Subtype
		{
			get;
			set;
		}
		string Type
		{
			get;
		}
	}
}
