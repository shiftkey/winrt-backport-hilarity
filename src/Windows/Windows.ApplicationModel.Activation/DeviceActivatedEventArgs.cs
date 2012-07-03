using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Activation
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class DeviceActivatedEventArgs : IDeviceActivatedEventArgs, IActivatedEventArgs
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
	}
}
