using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ComboBox)), Guid(1041549745u, 53595, 19913, 129, 16, 207, 58, 17, 123, 150, 231), Version(100794368u), WebHostHidden]
	internal interface IComboBoxStatics
	{
		DependencyProperty IsDropDownOpenProperty
		{
			get;
		}
		DependencyProperty MaxDropDownHeightProperty
		{
			get;
		}
	}
}
