using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(Application)), Guid(1958240673u, 29831, 18089, 154, 110, 199, 139, 81, 39, 38, 197), Version(100794368u), WebHostHidden]
	internal interface IApplication
	{
		event EventHandler<object> Resuming;
		event SuspendingEventHandler Suspending;
		event UnhandledExceptionEventHandler UnhandledException;
		DebugSettings DebugSettings
		{
			get;
		}
		ApplicationTheme RequestedTheme
		{
			get;
			set;
		}
		ResourceDictionary Resources
		{
			get;
			set;
		}
		void Exit();
	}
}
