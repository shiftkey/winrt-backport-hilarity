using System;
using Windows.Foundation.Metadata;
using Windows.Storage.Pickers.Provider;
namespace Windows.ApplicationModel.Activation
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class FileOpenPickerActivatedEventArgs : IFileOpenPickerActivatedEventArgs, IActivatedEventArgs
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
	}
}
