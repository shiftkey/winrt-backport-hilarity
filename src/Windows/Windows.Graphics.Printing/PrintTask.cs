using System;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class PrintTask : IPrintTask
	{
		public extern event TypedEventHandler<PrintTask, PrintTaskCompletedEventArgs> Completed
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<PrintTask, object> Previewing
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<PrintTask, PrintTaskProgressingEventArgs> Progressing
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<PrintTask, object> Submitting
		{
			add;
			remove;
		}
		public extern PrintTaskOptions Options
		{
			get;
		}
		public extern DataPackagePropertySet Properties
		{
			get;
		}
		public extern IPrintDocumentSource Source
		{
			get;
		}
	}
}
