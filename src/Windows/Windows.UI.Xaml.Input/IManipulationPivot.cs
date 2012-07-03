using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Input
{
	[ExclusiveTo(typeof(ManipulationPivot)), Guid(775436453u, 59074, 18840, 130, 172, 24, 116, 139, 20, 22, 102), Version(100794368u), WebHostHidden]
	internal interface IManipulationPivot
	{
		Point Center
		{
			get;
			set;
		}
		double Radius
		{
			get;
			set;
		}
	}
}
