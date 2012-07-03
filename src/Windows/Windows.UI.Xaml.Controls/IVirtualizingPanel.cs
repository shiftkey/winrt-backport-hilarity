using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(VirtualizingPanel)), Guid(950719756u, 4815, 19742, 168, 132, 201, 223, 133, 240, 124, 217), Version(100794368u), WebHostHidden]
	internal interface IVirtualizingPanel
	{
		ItemContainerGenerator ItemContainerGenerator
		{
			get;
		}
	}
}
