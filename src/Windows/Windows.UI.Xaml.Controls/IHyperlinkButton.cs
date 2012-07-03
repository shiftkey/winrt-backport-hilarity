using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(HyperlinkButton)), Guid(3437997219u, 15196, 20300, 155, 253, 134, 136, 123, 199, 151, 114), Version(100794368u), WebHostHidden]
	internal interface IHyperlinkButton
	{
		Uri NavigateUri
		{
			get;
			set;
		}
	}
}
