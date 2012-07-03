using System;
using Windows.ApplicationModel.Activation;
using Windows.Foundation.Metadata;
namespace Windows.UI.WebUI
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u)]
	public sealed class WebUIDeviceActivatedEventArgs : IDeviceActivatedEventArgs, IActivatedEventArgs, IActivatedEventArgsDeferral
	{
		public extern string DeviceInformationId
		{
			get;
		}
		public extern string Verb
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
