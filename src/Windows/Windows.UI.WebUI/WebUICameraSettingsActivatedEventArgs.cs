using System;
using Windows.ApplicationModel.Activation;
using Windows.Foundation.Metadata;
namespace Windows.UI.WebUI
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u)]
	public sealed class WebUICameraSettingsActivatedEventArgs : ICameraSettingsActivatedEventArgs, IActivatedEventArgs, IActivatedEventArgsDeferral
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
		public extern ActivatedOperation ActivatedOperation
		{
			get;
		}
	}
}
