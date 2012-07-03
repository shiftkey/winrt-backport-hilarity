using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.Data.Xml.Dom
{
	[ExclusiveTo(typeof(XmlDocument)), Guid(1825630030u, 61029, 17545, 158, 191, 202, 67, 232, 123, 166, 55), Version(100794368u)]
	internal interface IXmlDocumentIO
	{
		[Overload("LoadXml")]
		void LoadXml([In] string xml);
		[Overload("LoadXmlWithSettings")]
		void LoadXml([In] string xml, [In] XmlLoadSettings loadSettings);
		IAsyncAction SaveToFileAsync([In] IStorageFile file);
	}
}
