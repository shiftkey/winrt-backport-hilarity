using System;
using Windows.ApplicationModel.Activation;
using Windows.Foundation.Metadata;
using Windows.Storage.Pickers.Provider;
namespace Windows.UI.WebUI
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u)]
	public sealed class WebUIFileOpenPickerActivatedEventArgs : IFileOpenPickerActivatedEventArgs, IActivatedEventArgs, IActivatedEventArgsDeferral
	{
		public extern FileOpenPickerUI FileOpenPickerUI
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
