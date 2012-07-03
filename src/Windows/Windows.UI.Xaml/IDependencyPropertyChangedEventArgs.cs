using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(DependencyPropertyChangedEventArgs)), Guid(2166434859u, 9424, 18775, 171, 195, 34, 68, 112, 169, 58, 78), Version(100794368u), WebHostHidden]
	internal interface IDependencyPropertyChangedEventArgs
	{
		object NewValue
		{
			get;
		}
		object OldValue
		{
			get;
		}
		DependencyProperty Property
		{
			get;
		}
	}
}
