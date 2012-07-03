using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ListBox)), Guid(3925064191u, 36497, 20175, 167, 7, 201, 39, 246, 148, 248, 129), Version(100794368u), WebHostHidden]
	internal interface IListBox
	{
		IVector<object> SelectedItems
		{
			get;
		}
		SelectionMode SelectionMode
		{
			get;
			set;
		}
		void ScrollIntoView([In] object item);
		void SelectAll();
	}
}
