using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Standard), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class PlayToReceiver : IPlayToReceiver
	{
		public extern event TypedEventHandler<PlayToReceiver, CurrentTimeChangeRequestedEventArgs> CurrentTimeChangeRequested
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<PlayToReceiver, MuteChangeRequestedEventArgs> MuteChangeRequested
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<PlayToReceiver, object> PauseRequested
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<PlayToReceiver, object> PlayRequested
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<PlayToReceiver, PlaybackRateChangeRequestedEventArgs> PlaybackRateChangeRequested
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<PlayToReceiver, SourceChangeRequestedEventArgs> SourceChangeRequested
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<PlayToReceiver, object> StopRequested
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<PlayToReceiver, object> TimeUpdateRequested
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<PlayToReceiver, VolumeChangeRequestedEventArgs> VolumeChangeRequested
		{
			add;
			remove;
		}
		public extern string FriendlyName
		{
			get;
			set;
		}
		public extern IPropertySet Properties
		{
			get;
		}
		public extern bool SupportsAudio
		{
			get;
			set;
		}
		public extern bool SupportsImage
		{
			get;
			set;
		}
		public extern bool SupportsVideo
		{
			get;
			set;
		}
		public extern PlayToReceiver();
		public extern void NotifyVolumeChange([In] double volume, [In] bool mute);
		public extern void NotifyRateChange([In] double rate);
		public extern void NotifyLoadedMetadata();
		public extern void NotifyTimeUpdate([In] TimeSpan currentTime);
		public extern void NotifyDurationChange([In] TimeSpan duration);
		public extern void NotifySeeking();
		public extern void NotifySeeked();
		public extern void NotifyPaused();
		public extern void NotifyPlaying();
		public extern void NotifyEnded();
		public extern void NotifyError();
		public extern void NotifyStopped();
		public extern IAsyncAction StartAsync();
		public extern IAsyncAction StopAsync();
	}
}
