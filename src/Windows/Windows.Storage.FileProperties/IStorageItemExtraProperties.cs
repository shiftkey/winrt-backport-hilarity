using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.FileProperties
{
	[Guid(3309527474u, 21709, 17195, 189, 188, 75, 25, 196, 180, 112, 215), Version(100794368u)]
	public interface IStorageItemExtraProperties
	{
		IAsyncOperation<IMap<string, object>> RetrievePropertiesAsync([In] IIterable<string> propertiesToRetrieve);
		[Overload("SavePropertiesAsync")]
		IAsyncAction SavePropertiesAsync([HasVariant] [In] IIterable<IKeyValuePair<string, object>> propertiesToSave);
		[Overload("SavePropertiesAsyncOverloadDefault")]
		IAsyncAction SavePropertiesAsync();
	}
}
