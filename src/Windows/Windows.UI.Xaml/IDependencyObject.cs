using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Core;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(DependencyObject)), Guid(1548904037u, 62990, 18706, 175, 89, 95, 224, 104, 15, 8, 157), Version(100794368u), WebHostHidden]
	internal interface IDependencyObject
	{
		CoreDispatcher Dispatcher
		{
			get;
		}
		object GetValue([In] DependencyProperty dp);
		void SetValue([In] DependencyProperty dp, [In] object value);
		void ClearValue([In] DependencyProperty dp);
		object ReadLocalValue([In] DependencyProperty dp);
		object GetAnimationBaseValue([In] DependencyProperty dp);
	}
}
