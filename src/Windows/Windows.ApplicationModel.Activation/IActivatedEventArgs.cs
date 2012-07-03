using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Activation
{
	[Guid(3479508755u, 52488, 20440, 182, 151, 162, 129, 182, 84, 78, 46), Version(100794368u)]
	public interface IActivatedEventArgs
	{
		ActivationKind Kind
		{
			get;
		}
		ApplicationExecutionState PreviousExecutionState
		{
			get;
		}
		SplashScreen SplashScreen
		{
			get;
		}
	}
}
