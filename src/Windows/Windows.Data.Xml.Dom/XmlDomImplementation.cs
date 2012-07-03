using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Data.Xml.Dom
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class XmlDomImplementation : IXmlDomImplementation
	{
		public extern bool HasFeature([In] string feature, [Variant] [In] object version);
	}
}
