using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.FileProperties
{
	[Version(100794368u)]
	public sealed class MusicProperties : IMusicProperties, IStorageItemExtraProperties
	{
		public extern string Album
		{
			get;
			set;
		}
		public extern string AlbumArtist
		{
			get;
			set;
		}
		public extern string Artist
		{
			get;
			set;
		}
		public extern uint Bitrate
		{
			get;
		}
		public extern IVector<string> Composers
		{
			get;
		}
		public extern IVector<string> Conductors
		{
			get;
		}
		public extern TimeSpan Duration
		{
			get;
		}
		public extern IVector<string> Genre
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
		public extern uint TrackNumber
		{
			get;
			set;
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
