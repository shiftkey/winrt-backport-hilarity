using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Control)), Guid(395401338u, 10876, 18817, 162, 216, 171, 153, 255, 252, 101, 185), Version(100794368u), WebHostHidden]
	internal interface IControlProtected
	{
		object DefaultStyleKey
		{
			get;
			set;
		}
		DependencyObject GetTemplateChild([In] string childName);
	}
}
