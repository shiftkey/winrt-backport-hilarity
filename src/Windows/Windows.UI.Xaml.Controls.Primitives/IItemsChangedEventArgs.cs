using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(ItemsChangedEventArgs)), Guid(3904132456u, 32016, 16926, 190, 41, 129, 131, 154, 145, 222, 32), Version(100794368u), WebHostHidden]
	internal interface IItemsChangedEventArgs
	{
		int Action
		{
			get;
		}
		int ItemCount
		{
			get;
		}
		int ItemUICount
		{
			get;
		}
		GeneratorPosition OldPosition
		{
			get;
		}
		GeneratorPosition Position
		{
			get;
		}
	}
}
