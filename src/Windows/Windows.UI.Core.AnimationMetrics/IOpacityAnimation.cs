using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core.AnimationMetrics
{
	[ExclusiveTo(typeof(OpacityAnimation)), Guid(2151328741u, 61054, 17759, 132, 233, 37, 6, 175, 184, 210, 180), Version(100794368u)]
	internal interface IOpacityAnimation : IPropertyAnimation
	{
		float FinalOpacity
		{
			get;
		}
		IReference<float> InitialOpacity
		{
			get;
		}
	}
}
