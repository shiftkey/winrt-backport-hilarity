using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.Data.Xml.Dom
{
	[ExclusiveTo(typeof(XmlDocument)), Guid(1430508116u, 55127, 19321, 149, 57, 35, 43, 24, 245, 11, 241), Version(100794368u)]
	internal interface IXmlDocumentStatics
	{
		[Overload("LoadFromUriAsync")]
		IAsyncOperation<XmlDocument> LoadFromUriAsync([In] Uri uri);
		[Overload("LoadFromUriWithSettingsAsync")]
		IAsyncOperation<XmlDocument> LoadFromUriAsync([In] Uri uri, [In] XmlLoadSettings loadSettings);
		[Overload("LoadFromFileAsync")]
		IAsyncOperation<XmlDocument> LoadFromFileAsync([In] IStorageFile file);
		[Overload("LoadFromFileWithSettingsAsync")]
		IAsyncOperation<XmlDocument> LoadFromFileAsync([In] IStorageFile file, [In] XmlLoadSettings loadSettings);
	}
}
