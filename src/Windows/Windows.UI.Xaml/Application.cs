using System;
using System.Runtime.InteropServices;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml
{
	[Composable(typeof(IApplicationFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IApplicationStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class Application : IApplication, IApplicationOverrides
	{
		public extern event EventHandler<object> Resuming
		{
			add;
			remove;
		}
		public extern event SuspendingEventHandler Suspending
		{
			add;
			remove;
		}
		public extern event UnhandledExceptionEventHandler UnhandledException
		{
			add;
			remove;
		}
		public extern DebugSettings DebugSettings
		{
			get;
		}
		public extern ApplicationTheme RequestedTheme
		{
			get;
			set;
		}
		public extern ResourceDictionary Resources
		{
			get;
			set;
		}
		public static extern Application Current
		{
			get;
		}
		public extern Application();
		public extern void Exit();
		protected virtual extern void OnActivated([In] IActivatedEventArgs args);
		protected virtual extern void OnLaunched([In] LaunchActivatedEventArgs args);
		protected virtual extern void OnFileActivated([In] FileActivatedEventArgs args);
		protected virtual extern void OnSearchActivated([In] SearchActivatedEventArgs args);
		protected virtual extern void OnShareTargetActivated([In] ShareTargetActivatedEventArgs args);
		protected virtual extern void OnFileOpenPickerActivated([In] FileOpenPickerActivatedEventArgs args);
		protected virtual extern void OnFileSavePickerActivated([In] FileSavePickerActivatedEventArgs args);
		protected virtual extern void OnCachedFileUpdaterActivated([In] CachedFileUpdaterActivatedEventArgs args);
		public static extern void Start([In] ApplicationInitializationCallback callback);
		[DefaultOverload, Overload("LoadComponent")]
		public static extern void LoadComponent([In] object component, [In] Uri resourceLocator);
		[Overload("LoadComponentWithResourceLocation")]
		public static extern void LoadComponent([In] object component, [In] Uri resourceLocator, [In] ComponentResourceLocation componentResourceLocation);
	}
}
