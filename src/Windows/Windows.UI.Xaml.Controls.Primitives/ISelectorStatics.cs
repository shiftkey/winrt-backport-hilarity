using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(Selector)), Guid(321915654u, 48400, 19977, 191, 247, 113, 239, 184, 187, 180, 43), Version(100794368u), WebHostHidden]
	internal interface ISelectorStatics
	{
		DependencyProperty IsSynchronizedWithCurrentItemProperty
		{
			get;
		}
		DependencyProperty SelectedIndexProperty
		{
			get;
		}
		DependencyProperty SelectedItemProperty
		{
			get;
		}
		DependencyProperty SelectedValuePathProperty
		{
			get;
		}
		DependencyProperty SelectedValueProperty
		{
			get;
		}
		bool GetIsSelectionActive([In] DependencyObject element);
	}
}
