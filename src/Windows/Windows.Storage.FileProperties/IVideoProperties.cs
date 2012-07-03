using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.FileProperties
{
	[ExclusiveTo(typeof(VideoProperties)), Guid(1905976583u, 26846, 19896, 151, 222, 73, 153, 140, 5, 159, 47), Version(100794368u)]
	internal interface IVideoProperties : IStorageItemExtraProperties
	{
		uint Bitrate
		{
			get;
		}
		IVector<string> Directors
		{
			get;
		}
		TimeSpan Duration
		{
			get;
		}
		uint Height
		{
			get;
		}
		IVector<string> Keywords
		{
			get;
		}
		IReference<double> Latitude
		{
			get;
		}
		IReference<double> Longitude
		{
			get;
		}
		VideoOrientation Orientation
		{
			get;
		}
		IVector<string> Producers
		{
			get;
		}
		string Publisher
		{
			get;
			set;
		}
		uint Rating
		{
			get;
			set;
		}
		string Subtitle
		{
			get;
			set;
		}
		string Title
		{
			get;
			set;
		}
		uint Width
		{
			get;
		}
		IVector<string> Writers
		{
			get;
		}
		uint Year
		{
			get;
			set;
		}
	}
}
