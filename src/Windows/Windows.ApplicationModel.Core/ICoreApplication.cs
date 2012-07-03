using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Core
{
	[ExclusiveTo(typeof(CoreApplication)), Guid(179107748u, 24093, 18911, 128, 52, 251, 106, 104, 188, 94, 209), Version(100794368u), WebHostHidden]
	internal interface ICoreApplication
	{
		event EventHandler<object> Resuming;
		event EventHandler<SuspendingEventArgs> Suspending;
		string Id
		{
			get;
		}
		IPropertySet Properties
		{
			get;
		}
		CoreApplicationView GetCurrentView();
		[DefaultOverload, Overload("Run")]
		void Run([In] IFrameworkViewSource viewSource);
		[Overload("RunWithActivationFactories")]
		void Run([In] IGetActivationFactory activationFactoryCallback);
	}
}
