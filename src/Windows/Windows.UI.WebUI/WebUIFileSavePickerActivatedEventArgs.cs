using System;
using Windows.ApplicationModel.Activation;
using Windows.Foundation.Metadata;
using Windows.Storage.Pickers.Provider;
namespace Windows.UI.WebUI
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u)]
	public sealed class WebUIFileSavePickerActivatedEventArgs : IFileSavePickerActivatedEventArgs, IActivatedEventArgs, IActivatedEventArgsDeferral
	{
		public extern FileSavePickerUI FileSavePickerUI
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
