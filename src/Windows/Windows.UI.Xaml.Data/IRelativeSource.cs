using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Data
{
	[ExclusiveTo(typeof(RelativeSource)), Guid(597151364u, 10274, 18490, 180, 153, 208, 240, 49, 224, 108, 107), Version(100794368u), WebHostHidden]
	internal interface IRelativeSource
	{
		RelativeSourceMode Mode
		{
			get;
			set;
		}
	}
}
