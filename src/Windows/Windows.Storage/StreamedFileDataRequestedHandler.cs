using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	public delegate void StreamedFileDataRequestedHandler([In] StreamedFileDataRequest stream);
}
