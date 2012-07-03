using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(Setter)), Guid(2805853481u, 46254, 19073, 190, 133, 230, 144, 186, 13, 59, 110), Version(100794368u), WebHostHidden]
	internal interface ISetter
	{
		DependencyProperty Property
		{
			get;
			set;
		}
		object Value
		{
			get;
			set;
		}
	}
}
