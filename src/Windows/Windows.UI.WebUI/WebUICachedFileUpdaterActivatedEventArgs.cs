using System;
using Windows.ApplicationModel.Activation;
using Windows.Foundation.Metadata;
using Windows.Storage.Provider;
namespace Windows.UI.WebUI
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u)]
	public sealed class WebUICachedFileUpdaterActivatedEventArgs : ICachedFileUpdaterActivatedEventArgs, IActivatedEventArgs, IActivatedEventArgsDeferral
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
		public extern ActivatedOperation ActivatedOperation
		{
			get;
		}
	}
}
