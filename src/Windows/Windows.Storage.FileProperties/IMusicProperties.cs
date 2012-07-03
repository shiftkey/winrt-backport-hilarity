using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using TimeSpan = Windows.Foundation.TimeSpan;

namespace Windows.Storage.FileProperties
{
	[ExclusiveTo(typeof(MusicProperties))]
	internal interface IMusicProperties : IStorageItemExtraProperties
	{
		string Album
		{
			get;
			set;
		}
		string AlbumArtist
		{
			get;
			set;
		}
		string Artist
		{
			get;
			set;
		}
		uint Bitrate
		{
			get;
		}
		IVector<string> Composers
		{
			get;
		}
		IVector<string> Conductors
		{
			get;
		}
		TimeSpan Duration
		{
			get;
		}
		IVector<string> Genre
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
		uint TrackNumber
		{
			get;
			set;
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
