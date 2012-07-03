using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ComboBox)), Guid(1325491521u, 48382, 18978, 137, 50, 201, 20, 152, 28, 34, 64), Version(100794368u), WebHostHidden]
	internal interface IComboBoxOverrides
	{
		void OnDropDownClosed([In] object e);
		void OnDropDownOpened([In] object e);
	}
}
