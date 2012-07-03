using System;
using Windows.Foundation.Metadata;
using Windows.Storage.Pickers.Provider;
namespace Windows.ApplicationModel.Activation
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class FileSavePickerActivatedEventArgs : IFileSavePickerActivatedEventArgs, IActivatedEventArgs
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
	}
}
