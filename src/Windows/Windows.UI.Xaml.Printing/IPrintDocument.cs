using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;
namespace Windows.UI.Xaml.Printing
{
	[ExclusiveTo(typeof(PrintDocument)), Guid(3829606339u, 43417, 18523, 177, 216, 114, 220, 81, 120, 33, 230), Version(100794368u), WebHostHidden]
	internal interface IPrintDocument
	{
		event AddPagesEventHandler AddPages;
		event GetPreviewPageEventHandler GetPreviewPage;
		event PaginateEventHandler Paginate;
		IPrintDocumentSource DocumentSource
		{
			get;
		}
		void AddPage([In] UIElement pageVisual);
		void AddPagesComplete();
		void SetPreviewPageCount([In] int count, [In] PreviewPageCountType type);
		void SetPreviewPage([In] int pageNumber, [In] UIElement pageVisual);
		void InvalidatePreview();
	}
}
