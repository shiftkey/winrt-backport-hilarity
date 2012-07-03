using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.ApplicationModel.Activation
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class FileActivatedEventArgs : IFileActivatedEventArgs, IActivatedEventArgs
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
	}
}
