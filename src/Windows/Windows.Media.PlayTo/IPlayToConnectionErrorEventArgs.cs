using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[ExclusiveTo(typeof(PlayToConnectionErrorEventArgs)), Guid(3210653094u, 35046, 17503, 157, 64, 217, 185, 248, 147, 152, 150), Version(100794368u)]
	internal interface IPlayToConnectionErrorEventArgs
	{
		PlayToConnectionError Code
		{
			get;
		}
		string Message
		{
			get;
		}
	}
}
