using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ToggleSwitch)), Guid(3218112339u, 63690, 20039, 148, 158, 158, 128, 66, 155, 61, 22), Version(100794368u), WebHostHidden]
	internal interface IToggleSwitchOverrides
	{
		void OnToggled();
		void OnOnContentChanged([In] object oldContent, [In] object newContent);
		void OnOffContentChanged([In] object oldContent, [In] object newContent);
		void OnHeaderChanged([In] object oldContent, [In] object newContent);
	}
}
