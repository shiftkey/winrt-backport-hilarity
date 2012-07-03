using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[ExclusiveTo(typeof(PrintTaskRequestedEventArgs)), Guid(3501193508u, 41755, 17740, 167, 182, 93, 12, 197, 34, 252, 22), Version(100794368u)]
	internal interface IPrintTaskRequestedEventArgs
	{
		PrintTaskRequest Request
		{
			get;
		}
	}
}
