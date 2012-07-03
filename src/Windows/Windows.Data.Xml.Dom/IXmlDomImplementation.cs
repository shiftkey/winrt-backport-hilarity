using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Data.Xml.Dom
{
	[ExclusiveTo(typeof(XmlDomImplementation)), Guid(1843757362u, 61725, 20411, 140, 198, 88, 60, 186, 147, 17, 47), Version(100794368u)]
	internal interface IXmlDomImplementation
	{
		bool HasFeature([In] string feature, [Variant] [In] object version);
	}
}
