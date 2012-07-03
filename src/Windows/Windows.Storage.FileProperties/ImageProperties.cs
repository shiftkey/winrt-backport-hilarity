using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.FileProperties
{
	[Version(100794368u)]
	public sealed class ImageProperties : IImageProperties, IStorageItemExtraProperties
	{
		public extern string CameraManufacturer
		{
			get;
			set;
		}
		public extern string CameraModel
		{
			get;
			set;
		}
		public extern DateTime DateTaken
		{
			get;
			set;
		}
		public extern uint Height
		{
			get;
		}
		public extern IVector<string> Keywords
		{
			get;
		}
		public extern IReference<double> Latitude
		{
			get;
		}
		public extern IReference<double> Longitude
		{
			get;
		}
		public extern PhotoOrientation Orientation
		{
			get;
		}
		public extern IVectorView<string> PeopleNames
		{
			get;
		}
		public extern uint Rating
		{
			get;
			set;
		}
		public extern string Title
		{
			get;
			set;
		}
		public extern uint Width
		{
			get;
		}
		public extern IAsyncOperation<IMap<string, object>> RetrievePropertiesAsync([In] IIterable<string> propertiesToRetrieve);
		[Overload("SavePropertiesAsync")]
		public extern IAsyncAction SavePropertiesAsync([HasVariant] [In] IIterable<IKeyValuePair<string, object>> propertiesToSave);
		[Overload("SavePropertiesAsyncOverloadDefault")]
		public extern IAsyncAction SavePropertiesAsync();
	}
}
