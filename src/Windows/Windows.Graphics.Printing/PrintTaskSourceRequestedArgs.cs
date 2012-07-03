using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class PrintTaskSourceRequestedArgs : IPrintTaskSourceRequestedArgs
	{
		public extern DateTime Deadline
		{
			get;
		}
		public extern void SetSource([In] IPrintDocumentSource source);
		public extern PrintTaskSourceRequestedDeferral GetDeferral();
	}
}
