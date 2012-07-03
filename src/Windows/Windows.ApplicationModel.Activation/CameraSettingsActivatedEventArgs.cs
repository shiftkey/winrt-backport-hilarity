using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Activation
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class CameraSettingsActivatedEventArgs : ICameraSettingsActivatedEventArgs, IActivatedEventArgs
	{
		public extern object VideoDeviceController
		{
			get;
		}
		public extern object VideoDeviceExtension
		{
			get;
		}
		public extern ActivationKind Kind
		{
			get;
		}
		public extern ApplicationExecutionState PreviousExecutionState
		{
			get;
		}
		public extern SplashScreen SplashScreen
		{
			get;
		}
	}
}
