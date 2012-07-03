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
	[ExclusiveTo(typeof(MediaElement)), Guid(2744046287u, 5086, 17049, 173, 226, 174, 24, 247, 78, 211, 83), Version(100794368u), WebHostHidden]
	internal interface IMediaElement
	{
		event RoutedEventHandler BufferingProgressChanged;
		event RoutedEventHandler CurrentStateChanged;
		event RoutedEventHandler DownloadProgressChanged;
		event TimelineMarkerRoutedEventHandler MarkerReached;
		event RoutedEventHandler MediaEnded;
		event ExceptionRoutedEventHandler MediaFailed;
		event RoutedEventHandler MediaOpened;
		event RateChangedRoutedEventHandler RateChanged;
		event RoutedEventHandler SeekCompleted;
		event RoutedEventHandler VolumeChanged;
		int AspectRatioHeight
		{
			get;
		}
		int AspectRatioWidth
		{
			get;
		}
		AudioCategory AudioCategory
		{
			get;
			set;
		}
		AudioDeviceType AudioDeviceType
		{
			get;
			set;
		}
		int AudioStreamCount
		{
			get;
		}
		IReference<int> AudioStreamIndex
		{
			get;
			set;
		}
		bool AutoPlay
		{
			get;
			set;
		}
		double Balance
		{
			get;
			set;
		}
		double BufferingProgress
		{
			get;
		}
		bool CanPause
		{
			get;
		}
		bool CanSeek
		{
			get;
		}
		MediaElementState CurrentState
		{
			get;
		}
		double DefaultPlaybackRate
		{
			get;
			set;
		}
		double DownloadProgress
		{
			get;
		}
		double DownloadProgressOffset
		{
			get;
		}
		bool IsAudioOnly
		{
			get;
		}
		bool IsLooping
		{
			get;
			set;
		}
		bool IsMuted
		{
			get;
			set;
		}
		bool IsStereo3DVideo
		{
			get;
		}
		TimelineMarkerCollection Markers
		{
			get;
		}
		Duration NaturalDuration
		{
			get;
		}
		int NaturalVideoHeight
		{
			get;
		}
		int NaturalVideoWidth
		{
			get;
		}
		PlayToSource PlayToSource
		{
			get;
		}
		double PlaybackRate
		{
			get;
			set;
		}
		TimeSpan Position
		{
			get;
			set;
		}
		ImageSource PosterSource
		{
			get;
			set;
		}
		MediaProtectionManager ProtectionManager
		{
			get;
			set;
		}
		bool RealTimePlayback
		{
			get;
			set;
		}
		Uri Source
		{
			get;
			set;
		}
		Stereo3DVideoPackingMode Stereo3DVideoPackingMode
		{
			get;
			set;
		}
		Stereo3DVideoRenderMode Stereo3DVideoRenderMode
		{
			get;
			set;
		}
		double Volume
		{
			get;
			set;
		}
		void Stop();
		void Play();
		void Pause();
		MediaCanPlayResponse CanPlayType([In] string type);
		void SetSource([In] IRandomAccessStream stream, [In] string mimeType);
		string GetAudioStreamLanguage([In] IReference<int> index);
		void AddAudioEffect([In] string effectID, [In] bool effectOptional, [In] IPropertySet effectConfiguration);
		void AddVideoEffect([In] string effectID, [In] bool effectOptional, [In] IPropertySet effectConfiguration);
		void RemoveAllEffects();
	}
}
