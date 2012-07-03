using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Data.Xml.Dom
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class XmlNodeList : IXmlNodeList, IVectorView<IXmlNode>, IIterable<IXmlNode>
	{
		public extern uint Length
		{
			get;
		}
		public extern uint Size
		{
			get;
		}
		public extern IXmlNode Item([In] uint index);
		public extern IXmlNode GetAt([In] uint index);
		public extern bool IndexOf([In] IXmlNode value, out uint index);
		public extern uint GetMany([In] uint startIndex, [Out] IXmlNode[] items);
		public extern IIterator<IXmlNode> First();
	}
}
