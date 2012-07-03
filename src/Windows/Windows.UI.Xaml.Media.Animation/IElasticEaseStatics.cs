using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(ElasticEase)), Guid(2851432172u, 65180, 19243, 142, 82, 187, 120, 93, 86, 33, 133), Version(100794368u), WebHostHidden]
	internal interface IElasticEaseStatics
	{
		DependencyProperty OscillationsProperty
		{
			get;
		}
		DependencyProperty SpringinessProperty
		{
			get;
		}
	}
}
