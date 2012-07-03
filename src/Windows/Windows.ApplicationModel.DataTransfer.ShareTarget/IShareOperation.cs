using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.DataTransfer.ShareTarget
{
	[ExclusiveTo(typeof(ShareOperation)), Guid(575060664u, 53496, 16833, 168, 42, 65, 55, 219, 101, 4, 251), Version(100794368u)]
	internal interface IShareOperation
	{
		DataPackageView Data
		{
			get;
		}
		string QuickLinkId
		{
			get;
		}
		void RemoveThisQuickLink();
		void ReportStarted();
		void ReportDataRetrieved();
		void ReportSubmittedBackgroundTask();
		[Overload("ReportCompletedWithQuickLink")]
		void ReportCompleted([In] QuickLink quicklink);
		[Overload("ReportCompleted")]
		void ReportCompleted();
		void ReportError([In] string value);
	}
}
