using System.Runtime.InteropServices;

namespace Windows.Storage
{
	public interface IStreamedFileDataRequest
	{
		void FailAndClose([In] StreamedFileFailureMode failureMode);
	}
}
