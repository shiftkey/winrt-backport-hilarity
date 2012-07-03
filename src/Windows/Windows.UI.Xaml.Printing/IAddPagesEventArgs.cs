using System;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;
namespace Windows.UI.Xaml.Printing
{
	[ExclusiveTo(typeof(AddPagesEventArgs)), Guid(3806669797u, 1388, 17440, 151, 149, 203, 53, 38, 206, 12, 32), Version(100794368u), WebHostHidden]
	internal interface IAddPagesEventArgs
	{
		PrintTaskOptions PrintTaskOptions
		{
			get;
		}
	}
}
