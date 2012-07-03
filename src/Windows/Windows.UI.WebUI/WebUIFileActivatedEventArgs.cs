using System;
using Windows.ApplicationModel.Activation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.UI.WebUI
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u)]
	public sealed class WebUIFileActivatedEventArgs : IFileActivatedEventArgs, IActivatedEventArgs, IActivatedEventArgsDeferral
	{
		public extern IVectorView<IStorageItem> Files
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
