using System;
using Windows.Foundation.Metadata;
namespace Windows.Media
{
	[ExclusiveTo(typeof(VideoEffects)), Guid(533571048u, 47857, 17697, 152, 12, 59, 206, 187, 68, 207, 56), Version(100794368u)]
	internal interface IVideoEffectsStatics
	{
		string VideoStabilization
		{
			get;
		}
	}
}
