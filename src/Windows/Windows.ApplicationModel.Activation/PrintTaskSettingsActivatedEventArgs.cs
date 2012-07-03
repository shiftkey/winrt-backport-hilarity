using System;
using Windows.Devices.Printers.Extensions;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Activation
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class PrintTaskSettingsActivatedEventArgs : IPrintTaskSettingsActivatedEventArgs, IActivatedEventArgs
	{
		public extern PrintTaskConfiguration Configuration
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
