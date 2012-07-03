using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Documents
{
	[ExclusiveTo(typeof(TextElement)), Guid(216145639u, 20342, 19929, 191, 145, 22, 59, 236, 207, 132, 188), Version(100794368u), WebHostHidden]
	internal interface ITextElementOverrides
	{
		void OnDisconnectVisualChildren();
	}
}
