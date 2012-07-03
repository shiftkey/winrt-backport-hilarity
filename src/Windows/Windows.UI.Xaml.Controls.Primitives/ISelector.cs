using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(Selector)), Guid(3809391525u, 45931, 17116, 133, 39, 205, 37, 19, 108, 8, 60), Version(100794368u), WebHostHidden]
	internal interface ISelector
	{
		event SelectionChangedEventHandler SelectionChanged;
		IReference<bool> IsSynchronizedWithCurrentItem
		{
			get;
			set;
		}
		int SelectedIndex
		{
			get;
			set;
		}
		object SelectedItem
		{
			get;
			set;
		}
		object SelectedValue
		{
			get;
			set;
		}
		string SelectedValuePath
		{
			get;
			set;
		}
	}
}
