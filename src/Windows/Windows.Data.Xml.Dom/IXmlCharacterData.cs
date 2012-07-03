using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Data.Xml.Dom
{
	[Guid(321798827u, 20022, 19958, 177, 200, 12, 230, 47, 216, 139, 38), Version(100794368u)]
	public interface IXmlCharacterData : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
	{
		string Data
		{
			get;
			set;
		}
		uint Length
		{
			get;
		}
		string SubstringData([In] uint offset, [In] uint count);
		void AppendData([In] string data);
		void InsertData([In] uint offset, [In] string data);
		void DeleteData([In] uint offset, [In] uint count);
		void ReplaceData([In] uint offset, [In] uint count, [In] string data);
	}
}
