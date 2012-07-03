using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Activation
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class LaunchActivatedEventArgs : ILaunchActivatedEventArgs, IActivatedEventArgs
	{
		public extern string Arguments
		{
			get;
		}
		public extern string TileId
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
