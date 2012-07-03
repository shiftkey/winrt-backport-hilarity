using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	[Guid(376700110u, 55997, 19792, 190, 238, 24, 11, 138, 129, 145, 182), Version(100794368u)]
	public interface IStreamedFileDataRequest
	{
		void FailAndClose([In] StreamedFileFailureMode failureMode);
	}
}
