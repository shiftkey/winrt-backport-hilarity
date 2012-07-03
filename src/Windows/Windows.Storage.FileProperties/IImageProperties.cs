using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using DateTime = Windows.Foundation.DateTime;

namespace Windows.Storage.FileProperties
{
	[ExclusiveTo(typeof(ImageProperties)), Guid(1379701796u, 64767, 17013, 175, 238, 236, 219, 154, 180, 121, 115), Version(100794368u)]
	internal interface IImageProperties : IStorageItemExtraProperties
	{
		string CameraManufacturer
		{
			get;
			set;
		}
		string CameraModel
		{
			get;
			set;
		}
		DateTime DateTaken
		{
			get;
			set;
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
		PhotoOrientation Orientation
		{
			get;
		}
		IVectorView<string> PeopleNames
		{
			get;
		}
		uint Rating
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
	}
}
