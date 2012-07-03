using System;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.DataTransfer.ShareTarget;
using Windows.Foundation.Metadata;
namespace Windows.UI.WebUI
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u)]
	public sealed class WebUIShareTargetActivatedEventArgs : IShareTargetActivatedEventArgs, IActivatedEventArgs, IActivatedEventArgsDeferral
	{
		public extern ShareOperation ShareOperation
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
