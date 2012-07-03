using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(ToggleButton)), Guid(1486387195u, 4039, 16438, 157, 139, 18, 125, 250, 117, 193, 109), Version(100794368u), WebHostHidden]
	internal interface IToggleButton
	{
		event RoutedEventHandler Checked;
		event RoutedEventHandler Indeterminate;
		event RoutedEventHandler Unchecked;
		IReference<bool> IsChecked
		{
			get;
			set;
		}
		bool IsThreeState
		{
			get;
			set;
		}
	}
}
