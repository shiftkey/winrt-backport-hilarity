using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Security.Cryptography.Certificates
{
	[ExclusiveTo(typeof(CertificateEnrollmentManager)), Guid(2286350143u, 43398, 18683, 159, 215, 154, 236, 6, 147, 91, 241), Version(134217728u)]
	internal interface ICertificateEnrollmentManagerStatics
	{
		IAsyncOperation<string> CreateRequestAsync([In] CertificateRequestProperties request);
		IAsyncAction InstallCertificateAsync([In] string certificate, [In] InstallOptions installOption);
		IAsyncAction ImportPfxDataAsync([In] string pfxData, [In] string password, [In] ExportOption exportable, [In] KeyProtectionLevel keyProtectionLevel, [In] InstallOptions installOption, [In] string friendlyName);
	}
}
