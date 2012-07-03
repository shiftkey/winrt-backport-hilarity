using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Data.Xml.Dom
{
	[Guid(4180780235u, 12429, 18272, 161, 213, 67, 182, 116, 80, 172, 126), Version(100794368u)]
	public interface IXmlText : IXmlCharacterData, IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
	{
		IXmlText SplitText([In] uint offset);
	}
}
