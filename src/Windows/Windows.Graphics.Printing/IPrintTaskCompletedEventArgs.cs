using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[ExclusiveTo(typeof(PrintTaskCompletedEventArgs)), Guid(1540175023u, 9449, 19472, 141, 7, 20, 195, 70, 186, 63, 206), Version(100794368u)]
	internal interface IPrintTaskCompletedEventArgs
	{
		PrintTaskCompletion Completion
		{
			get;
		}
	}
}
