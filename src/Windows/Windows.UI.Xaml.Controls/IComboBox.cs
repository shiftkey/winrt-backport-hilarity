using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ComboBox)), Guid(3114848348u, 44183, 18417, 165, 244, 63, 159, 77, 75, 17, 108), Version(100794368u), WebHostHidden]
	internal interface IComboBox
	{
		event EventHandler<object> DropDownClosed;
		event EventHandler<object> DropDownOpened;
		bool IsDropDownOpen
		{
			get;
			set;
		}
		bool IsEditable
		{
			get;
		}
		bool IsSelectionBoxHighlighted
		{
			get;
		}
		double MaxDropDownHeight
		{
			get;
			set;
		}
		object SelectionBoxItem
		{
			get;
		}
		DataTemplate SelectionBoxItemTemplate
		{
			get;
		}
		ComboBoxTemplateSettings TemplateSettings
		{
			get;
		}
	}
}
