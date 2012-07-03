using System;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[ExclusiveTo(typeof(PrintTask)), Guid(1641546311u, 27894, 20397, 132, 226, 165, 232, 46, 45, 76, 235), Version(100794368u)]
	internal interface IPrintTask
	{
		event TypedEventHandler<PrintTask, PrintTaskCompletedEventArgs> Completed;
		event TypedEventHandler<PrintTask, object> Previewing;
		event TypedEventHandler<PrintTask, PrintTaskProgressingEventArgs> Progressing;
		event TypedEventHandler<PrintTask, object> Submitting;
		PrintTaskOptions Options
		{
			get;
		}
		DataPackagePropertySet Properties
		{
			get;
		}
		IPrintDocumentSource Source
		{
			get;
		}
	}
}
