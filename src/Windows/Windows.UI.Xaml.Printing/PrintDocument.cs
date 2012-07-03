using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;
namespace Windows.UI.Xaml.Printing
{
	[Composable(typeof(IPrintDocumentFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPrintDocumentStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class PrintDocument : DependencyObject, IPrintDocument
	{
		public extern event AddPagesEventHandler AddPages
		{
			add;
			remove;
		}
		public extern event GetPreviewPageEventHandler GetPreviewPage
		{
			add;
			remove;
		}
		public extern event PaginateEventHandler Paginate
		{
			add;
			remove;
		}
		public extern IPrintDocumentSource DocumentSource
		{
			get;
		}
		public static extern DependencyProperty DocumentSourceProperty
		{
			get;
		}
		public extern PrintDocument();
		public extern void AddPage([In] UIElement pageVisual);
		public extern void AddPagesComplete();
		public extern void SetPreviewPageCount([In] int count, [In] PreviewPageCountType type);
		public extern void SetPreviewPage([In] int pageNumber, [In] UIElement pageVisual);
		public extern void InvalidatePreview();
	}
}
