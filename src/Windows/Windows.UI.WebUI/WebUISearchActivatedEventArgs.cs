using System;
using Windows.ApplicationModel.Activation;
using Windows.Foundation.Metadata;
namespace Windows.UI.WebUI
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u)]
	public sealed class WebUISearchActivatedEventArgs : ISearchActivatedEventArgs, IActivatedEventArgs, IActivatedEventArgsDeferral
	{
		public extern string Language
		{
			get;
		}
		public extern string QueryText
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
