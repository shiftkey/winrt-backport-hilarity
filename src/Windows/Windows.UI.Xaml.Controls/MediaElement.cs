using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.PlayTo;
using Windows.Media.Protection;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Controls
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IMediaElementStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class MediaElement : FrameworkElement, IMediaElement
	{
		public extern event RoutedEventHandler BufferingProgressChanged
		{
			add;
			remove;
		}
		public extern event RoutedEventHandler CurrentStateChanged
		{
			add;
			remove;
		}
		public extern event RoutedEventHandler DownloadProgressChanged
		{
			add;
			remove;
		}
		public extern event TimelineMarkerRoutedEventHandler MarkerReached
		{
			add;
			remove;
		}
		public extern event RoutedEventHandler MediaEnded
		{
			add;
			remove;
		}
		public extern event ExceptionRoutedEventHandler MediaFailed
		{
			add;
			remove;
		}
		public extern event RoutedEventHandler MediaOpened
		{
			add;
			remove;
		}
		public extern event RateChangedRoutedEventHandler RateChanged
		{
			add;
			remove;
		}
		public extern event RoutedEventHandler SeekCompleted
		{
			add;
			remove;
		}
		public extern event RoutedEventHandler VolumeChanged
		{
			add;
			remove;
		}
		public extern int AspectRatioHeight
		{
			get;
		}
		public extern int AspectRatioWidth
		{
			get;
		}
		public extern AudioCategory AudioCategory
		{
			get;
			set;
		}
		public extern AudioDeviceType AudioDeviceType
		{
			get;
			set;
		}
		public extern int AudioStreamCount
		{
			get;
		}
		public extern IReference<int> AudioStreamIndex
		{
			get;
			set;
		}
		public extern bool AutoPlay
		{
			get;
			set;
		}
		public extern double Balance
		{
			get;
			set;
		}
		public extern double BufferingProgress
		{
			get;
		}
		public extern bool CanPause
		{
			get;
		}
		public extern bool CanSeek
		{
			get;
		}
		public extern MediaElementState CurrentState
		{
			get;
		}
		public extern double DefaultPlaybackRate
		{
			get;
			set;
		}
		public extern double DownloadProgress
		{
			get;
		}
		public extern double DownloadProgressOffset
		{
			get;
		}
		public extern bool IsAudioOnly
		{
			get;
		}
		public extern bool IsLooping
		{
			get;
			set;
		}
		public extern bool IsMuted
		{
			get;
			set;
		}
		public extern bool IsStereo3DVideo
		{
			get;
		}
		public extern TimelineMarkerCollection Markers
		{
			get;
		}
		public extern Duration NaturalDuration
		{
			get;
		}
		public extern int NaturalVideoHeight
		{
			get;
		}
		public extern int NaturalVideoWidth
		{
			get;
		}
		public extern PlayToSource PlayToSource
		{
			get;
		}
		public extern double PlaybackRate
		{
			get;
			set;
		}
		public extern TimeSpan Position
		{
			get;
			set;
		}
		public extern ImageSource PosterSource
		{
			get;
			set;
		}
		public extern MediaProtectionManager ProtectionManager
		{
			get;
			set;
		}
		public extern bool RealTimePlayback
		{
			get;
			set;
		}
		public extern Uri Source
		{
			get;
			set;
		}
		public extern Stereo3DVideoPackingMode Stereo3DVideoPackingMode
		{
			get;
			set;
		}
		public extern Stereo3DVideoRenderMode Stereo3DVideoRenderMode
		{
			get;
			set;
		}
		public extern double Volume
		{
			get;
			set;
		}
		public static extern DependencyProperty AspectRatioHeightProperty
		{
			get;
		}
		public static extern DependencyProperty AspectRatioWidthProperty
		{
			get;
		}
		public static extern DependencyProperty AudioCategoryProperty
		{
			get;
		}
		public static extern DependencyProperty AudioDeviceTypeProperty
		{
			get;
		}
		public static extern DependencyProperty AudioStreamCountProperty
		{
			get;
		}
		public static extern DependencyProperty AudioStreamIndexProperty
		{
			get;
		}
		public static extern DependencyProperty AutoPlayProperty
		{
			get;
		}
		public static extern DependencyProperty BalanceProperty
		{
			get;
		}
		public static extern DependencyProperty BufferingProgressProperty
		{
			get;
		}
		public static extern DependencyProperty CanPauseProperty
		{
			get;
		}
		public static extern DependencyProperty CanSeekProperty
		{
			get;
		}
		public static extern DependencyProperty CurrentStateProperty
		{
			get;
		}
		public static extern DependencyProperty DefaultPlaybackRateProperty
		{
			get;
		}
		public static extern DependencyProperty DownloadProgressOffsetProperty
		{
			get;
		}
		public static extern DependencyProperty DownloadProgressProperty
		{
			get;
		}
		public static extern DependencyProperty IsAudioOnlyProperty
		{
			get;
		}
		public static extern DependencyProperty IsLoopingProperty
		{
			get;
		}
		public static extern DependencyProperty IsMutedProperty
		{
			get;
		}
		public static extern DependencyProperty IsStereo3DVideoProperty
		{
			get;
		}
		public static extern DependencyProperty NaturalDurationProperty
		{
			get;
		}
		public static extern DependencyProperty NaturalVideoHeightProperty
		{
			get;
		}
		public static extern DependencyProperty NaturalVideoWidthProperty
		{
			get;
		}
		public static extern DependencyProperty PlayToSourceProperty
		{
			get;
		}
		public static extern DependencyProperty PlaybackRateProperty
		{
			get;
		}
		public static extern DependencyProperty PositionProperty
		{
			get;
		}
		public static extern DependencyProperty PosterSourceProperty
		{
			get;
		}
		public static extern DependencyProperty ProtectionManagerProperty
		{
			get;
		}
		public static extern DependencyProperty RealTimePlaybackProperty
		{
			get;
		}
		public static extern DependencyProperty SourceProperty
		{
			get;
		}
		public static extern DependencyProperty Stereo3DVideoPackingModeProperty
		{
			get;
		}
		public static extern DependencyProperty Stereo3DVideoRenderModeProperty
		{
			get;
		}
		public static extern DependencyProperty VolumeProperty
		{
			get;
		}
		public extern MediaElement();
		public extern void Stop();
		public extern void Play();
		public extern void Pause();
		public extern MediaCanPlayResponse CanPlayType([In] string type);
		public extern void SetSource([In] IRandomAccessStream stream, [In] string mimeType);
		public extern string GetAudioStreamLanguage([In] IReference<int> index);
		public extern void AddAudioEffect([In] string effectID, [In] bool effectOptional, [In] IPropertySet effectConfiguration);
		public extern void AddVideoEffect([In] string effectID, [In] bool effectOptional, [In] IPropertySet effectConfiguration);
		public extern void RemoveAllEffects();
	}
}
