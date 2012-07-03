using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.FileProperties
{
	[Version(100794368u)]
	public sealed class VideoProperties : IVideoProperties, IStorageItemExtraProperties
	{
		public extern uint Bitrate
		{
			get;
		}
		public extern IVector<string> Directors
		{
			get;
		}
		public extern TimeSpan Duration
		{
			get;
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
		public extern VideoOrientation Orientation
		{
			get;
		}
		public extern IVector<string> Producers
		{
			get;
		}
		public extern string Publisher
		{
			get;
			set;
		}
		public extern uint Rating
		{
			get;
			set;
		}
		public extern string Subtitle
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
		public extern IVector<string> Writers
		{
			get;
		}
		public extern uint Year
		{
			get;
			set;
		}
		public extern IAsyncOperation<IMap<string, object>> RetrievePropertiesAsync([In] IIterable<string> propertiesToRetrieve);
		[Overload("SavePropertiesAsync")]
		public extern IAsyncAction SavePropertiesAsync([HasVariant] [In] IIterable<IKeyValuePair<string, object>> propertiesToSave);
		[Overload("SavePropertiesAsyncOverloadDefault")]
		public extern IAsyncAction SavePropertiesAsync();
	}
}
