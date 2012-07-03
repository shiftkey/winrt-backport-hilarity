using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[ExclusiveTo(typeof(PlayToManager)), Guid(1692838023u, 14722, 20283, 186, 32, 97, 85, 228, 53, 50, 91), Version(100794368u)]
	internal interface IPlayToManagerStatics
	{
		PlayToManager GetForCurrentView();
		void ShowPlayToUI();
	}
}
