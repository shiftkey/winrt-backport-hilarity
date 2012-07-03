using System;
using Windows.ApplicationModel.Activation;
using Windows.Devices.Printers.Extensions;
using Windows.Foundation.Metadata;
namespace Windows.UI.WebUI
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u)]
	public sealed class WebUIPrintTaskSettingsActivatedEventArgs : IPrintTaskSettingsActivatedEventArgs, IActivatedEventArgs, IActivatedEventArgsDeferral
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
		public extern ActivatedOperation ActivatedOperation
		{
			get;
		}
	}
}
