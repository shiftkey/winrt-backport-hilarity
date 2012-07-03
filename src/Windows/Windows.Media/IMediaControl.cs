using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Media
{
	[ExclusiveTo(typeof(MediaControl)), Guid(2565995489u, 31373, 17099, 182, 254, 143, 230, 152, 38, 79, 19), Version(100794368u)]
	internal interface IMediaControl
	{
		event EventHandler<object> ChannelDownPressed;
		event EventHandler<object> ChannelUpPressed;
		event EventHandler<object> FastForwardPressed;
		event EventHandler<object> NextTrackPressed;
		event EventHandler<object> PausePressed;
		event EventHandler<object> PlayPauseTogglePressed;
		event EventHandler<object> PlayPressed;
		event EventHandler<object> PreviousTrackPressed;
		event EventHandler<object> RecordPressed;
		event EventHandler<object> RewindPressed;
		event EventHandler<object> SoundLevelChanged;
		event EventHandler<object> StopPressed;
		Uri AlbumArt
		{
			get;
			set;
		}
		string ArtistName
		{
			get;
			set;
		}
		bool IsPlaying
		{
			get;
			set;
		}
		SoundLevel SoundLevel
		{
			get;
		}
		string TrackName
		{
			get;
			set;
		}
	}
}
