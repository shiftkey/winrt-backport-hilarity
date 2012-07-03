using System;
using Windows.Foundation.Metadata;
using Windows.Storage.Provider;
namespace Windows.ApplicationModel.Activation
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class CachedFileUpdaterActivatedEventArgs : ICachedFileUpdaterActivatedEventArgs, IActivatedEventArgs
	{
		public extern CachedFileUpdaterUI CachedFileUpdaterUI
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
