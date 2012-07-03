using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.DataTransfer
{
	[ExclusiveTo(typeof(TargetApplicationChosenEventArgs)), Guid(3396319404u, 10631, 20195, 156, 84, 216, 175, 188, 184, 108, 29), Version(100794368u)]
	internal interface ITargetApplicationChosenEventArgs
	{
		string ApplicationName
		{
			get;
		}
	}
}
