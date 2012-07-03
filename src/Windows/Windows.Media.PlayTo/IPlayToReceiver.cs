using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[ExclusiveTo(typeof(PlayToReceiver)), Guid(2887110471u, 41314, 19110, 175, 27, 58, 163, 95, 59, 144, 105), Version(100794368u)]
	internal interface IPlayToReceiver
	{
		event TypedEventHandler<PlayToReceiver, CurrentTimeChangeRequestedEventArgs> CurrentTimeChangeRequested;
		event TypedEventHandler<PlayToReceiver, MuteChangeRequestedEventArgs> MuteChangeRequested;
		event TypedEventHandler<PlayToReceiver, object> PauseRequested;
		event TypedEventHandler<PlayToReceiver, object> PlayRequested;
		event TypedEventHandler<PlayToReceiver, PlaybackRateChangeRequestedEventArgs> PlaybackRateChangeRequested;
		event TypedEventHandler<PlayToReceiver, SourceChangeRequestedEventArgs> SourceChangeRequested;
		event TypedEventHandler<PlayToReceiver, object> StopRequested;
		event TypedEventHandler<PlayToReceiver, object> TimeUpdateRequested;
		event TypedEventHandler<PlayToReceiver, VolumeChangeRequestedEventArgs> VolumeChangeRequested;
		string FriendlyName
		{
			get;
			set;
		}
		IPropertySet Properties
		{
			get;
		}
		bool SupportsAudio
		{
			get;
			set;
		}
		bool SupportsImage
		{
			get;
			set;
		}
		bool SupportsVideo
		{
			get;
			set;
		}
		void NotifyVolumeChange([In] double volume, [In] bool mute);
		void NotifyRateChange([In] double rate);
		void NotifyLoadedMetadata();
		void NotifyTimeUpdate([In] TimeSpan currentTime);
		void NotifyDurationChange([In] TimeSpan duration);
		void NotifySeeking();
		void NotifySeeked();
		void NotifyPaused();
		void NotifyPlaying();
		void NotifyEnded();
		void NotifyError();
		void NotifyStopped();
		IAsyncAction StartAsync();
		IAsyncAction StopAsync();
	}
}
