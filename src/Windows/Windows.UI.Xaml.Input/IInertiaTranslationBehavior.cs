using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Input
{
	[ExclusiveTo(typeof(InertiaTranslationBehavior)), Guid(1171498258u, 15154, 18562, 164, 194, 236, 250, 45, 75, 109, 240), Version(100794368u), WebHostHidden]
	internal interface IInertiaTranslationBehavior
	{
		double DesiredDeceleration
		{
			get;
			set;
		}
		double DesiredDisplacement
		{
			get;
			set;
		}
	}
}
