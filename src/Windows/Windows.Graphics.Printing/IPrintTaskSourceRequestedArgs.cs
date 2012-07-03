using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[ExclusiveTo(typeof(PrintTaskSourceRequestedArgs)), Guid(4193281982u, 62550, 16880, 156, 152, 92, 231, 62, 133, 20, 16), Version(100794368u)]
	internal interface IPrintTaskSourceRequestedArgs
	{
		DateTime Deadline
		{
			get;
		}
		void SetSource([In] IPrintDocumentSource source);
		PrintTaskSourceRequestedDeferral GetDeferral();
	}
}
