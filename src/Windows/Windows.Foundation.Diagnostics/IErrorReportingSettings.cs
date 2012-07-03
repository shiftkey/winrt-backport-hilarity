using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Foundation.Diagnostics
{
	[Guid(372676498u, 45118, 19361, 139, 184, 210, 143, 74, 180, 210, 192), Version(100794368u)]
	public interface IErrorReportingSettings
	{
		void SetErrorOptions([In] ErrorOptions value);
		ErrorOptions GetErrorOptions();
	}
}
