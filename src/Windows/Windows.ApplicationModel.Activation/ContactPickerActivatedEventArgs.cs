using System;
using Windows.ApplicationModel.Contacts.Provider;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Activation
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class ContactPickerActivatedEventArgs : IContactPickerActivatedEventArgs, IActivatedEventArgs
	{
		public extern ContactPickerUI ContactPickerUI
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
