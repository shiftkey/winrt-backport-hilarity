using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.FileProperties
{
	[Version(100794368u)]
	public sealed class DocumentProperties : IDocumentProperties, IStorageItemExtraProperties
	{
		public extern IVector<string> Author
		{
			get;
		}
		public extern string Comment
		{
			get;
			set;
		}
		public extern IVector<string> Keywords
		{
			get;
		}
		public extern string Title
		{
			get;
			set;
		}
		public extern IAsyncOperation<IMap<string, object>> RetrievePropertiesAsync([In] IIterable<string> propertiesToRetrieve);
		[Overload("SavePropertiesAsync")]
		public extern IAsyncAction SavePropertiesAsync([HasVariant] [In] IIterable<IKeyValuePair<string, object>> propertiesToSave);
		[Overload("SavePropertiesAsyncOverloadDefault")]
		public extern IAsyncAction SavePropertiesAsync();
	}
}
