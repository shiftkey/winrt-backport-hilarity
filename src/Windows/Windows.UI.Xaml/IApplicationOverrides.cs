using System;
using System.Runtime.InteropServices;
using Windows.ApplicationModel.Activation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(Application)), Guid(637116407u, 37703, 17818, 159, 172, 178, 208, 225, 28, 26, 15), Version(100794368u), WebHostHidden]
	internal interface IApplicationOverrides
	{
		void OnActivated([In] IActivatedEventArgs args);
		void OnLaunched([In] LaunchActivatedEventArgs args);
		void OnFileActivated([In] FileActivatedEventArgs args);
		void OnSearchActivated([In] SearchActivatedEventArgs args);
		void OnShareTargetActivated([In] ShareTargetActivatedEventArgs args);
		void OnFileOpenPickerActivated([In] FileOpenPickerActivatedEventArgs args);
		void OnFileSavePickerActivated([In] FileSavePickerActivatedEventArgs args);
		void OnCachedFileUpdaterActivated([In] CachedFileUpdaterActivatedEventArgs args);
	}
}
