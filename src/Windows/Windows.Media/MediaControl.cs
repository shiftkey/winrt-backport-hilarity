using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Media
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IMediaControl), 100794368u), Threading(ThreadingModel.MTA), Version(100794368u)]
	public static class MediaControl
	{
		public static extern event EventHandler<object> ChannelDownPressed
		{
			add;
			remove;
		}
		public static extern event EventHandler<object> ChannelUpPressed
		{
			add;
			remove;
		}
		public static extern event EventHandler<object> FastForwardPressed
		{
			add;
			remove;
		}
		public static extern event EventHandler<object> NextTrackPressed
		{
			add;
			remove;
		}
		public static extern event EventHandler<object> PausePressed
		{
			add;
			remove;
		}
		public static extern event EventHandler<object> PlayPauseTogglePressed
		{
			add;
			remove;
		}
		public static extern event EventHandler<object> PlayPressed
		{
			add;
			remove;
		}
		public static extern event EventHandler<object> PreviousTrackPressed
		{
			add;
			remove;
		}
		public static extern event EventHandler<object> RecordPressed
		{
			add;
			remove;
		}
		public static extern event EventHandler<object> RewindPressed
		{
			add;
			remove;
		}
		public static extern event EventHandler<object> SoundLevelChanged
		{
			add;
			remove;
		}
		public static extern event EventHandler<object> StopPressed
		{
			add;
			remove;
		}
		public static extern Uri AlbumArt
		{
			get;
			set;
		}
		public static extern string ArtistName
		{
			get;
			set;
		}
		public static extern bool IsPlaying
		{
			get;
			set;
		}
		public static extern SoundLevel SoundLevel
		{
			get;
		}
		public static extern string TrackName
		{
			get;
			set;
		}
	}
}
