using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Media
{
	[Guid(126963992u, 17887, 17451, 138, 63, 247, 130, 106, 99, 112, 171), Version(100794368u)]
	public interface IMediaExtension
	{
		void SetProperties([In] IPropertySet configuration);
	}
}
