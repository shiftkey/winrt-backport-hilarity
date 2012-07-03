using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[ExclusiveTo(typeof(PlayToSource)), Guid(2131986952u, 64439, 19209, 131, 86, 170, 95, 78, 51, 92, 49), Version(100794368u)]
	internal interface IPlayToSource
	{
		PlayToConnection Connection
		{
			get;
		}
		PlayToSource Next
		{
			get;
			set;
		}
		void PlayNext();
	}
}
