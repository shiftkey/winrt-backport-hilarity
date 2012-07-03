using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.DataTransfer.ShareTarget
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u)]
	public sealed class ShareOperation : IShareOperation
	{
		public extern DataPackageView Data
		{
			get;
		}
		public extern string QuickLinkId
		{
			get;
		}
		public extern void RemoveThisQuickLink();
		public extern void ReportStarted();
		public extern void ReportDataRetrieved();
		public extern void ReportSubmittedBackgroundTask();
		[Overload("ReportCompletedWithQuickLink")]
		public extern void ReportCompleted([In] QuickLink quicklink);
		[Overload("ReportCompleted")]
		public extern void ReportCompleted();
		public extern void ReportError([In] string value);
	}
}
