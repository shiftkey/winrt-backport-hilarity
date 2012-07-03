using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[ExclusiveTo(typeof(PlayToSourceDeferral)), Guid(1090554141u, 10126, 20265, 133, 155, 169, 229, 1, 5, 62, 125), Version(100794368u)]
	internal interface IPlayToSourceDeferral
	{
		void Complete();
	}
}
