using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Data.Xml.Dom
{
	[ExclusiveTo(typeof(XmlNodeList)), Guid(2355146103u, 33700, 20161, 156, 84, 123, 164, 41, 225, 61, 166), Version(100794368u)]
	internal interface IXmlNodeList : IVectorView<IXmlNode>, IIterable<IXmlNode>
	{
		uint Length
		{
			get;
		}
		IXmlNode Item([In] uint index);
	}
}
