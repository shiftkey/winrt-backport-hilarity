using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(ElasticEase)), Guid(4015760780u, 45238, 19052, 156, 168, 251, 66, 51, 241, 36, 89), Version(100794368u), WebHostHidden]
	internal interface IElasticEase
	{
		int Oscillations
		{
			get;
			set;
		}
		double Springiness
		{
			get;
			set;
		}
	}
}
