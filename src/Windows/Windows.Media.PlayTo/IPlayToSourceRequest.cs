using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[ExclusiveTo(typeof(PlayToSourceRequest)), Guid(4166534757u, 25844, 17568, 172, 13, 70, 141, 43, 143, 218, 131), Version(100794368u)]
	internal interface IPlayToSourceRequest
	{
		DateTime Deadline
		{
			get;
		}
		void DisplayErrorString([In] string errorString);
		PlayToSourceDeferral GetDeferral();
		void SetSource([In] PlayToSource value);
	}
}
