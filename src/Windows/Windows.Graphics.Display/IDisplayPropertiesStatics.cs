using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Graphics.Display
{
	[ExclusiveTo(typeof(DisplayProperties)), Guid(1765272973u, 12522, 19949, 130, 113, 69, 83, 255, 2, 246, 138), Version(100794368u)]
	internal interface IDisplayPropertiesStatics
	{
		event DisplayPropertiesEventHandler ColorProfileChanged;
		event DisplayPropertiesEventHandler LogicalDpiChanged;
		event DisplayPropertiesEventHandler OrientationChanged;
		event DisplayPropertiesEventHandler StereoEnabledChanged;
		DisplayOrientations AutoRotationPreferences
		{
			get;
			set;
		}
		DisplayOrientations CurrentOrientation
		{
			get;
		}
		float LogicalDpi
		{
			get;
		}
		DisplayOrientations NativeOrientation
		{
			get;
		}
		ResolutionScale ResolutionScale
		{
			get;
		}
		bool StereoEnabled
		{
			get;
		}
		IAsyncOperation<IRandomAccessStream> GetColorProfileAsync();
	}
}
