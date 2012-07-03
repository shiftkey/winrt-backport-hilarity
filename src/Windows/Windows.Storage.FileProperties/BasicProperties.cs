using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using DateTime = Windows.Foundation.DateTime;

namespace Windows.Storage.FileProperties
{
	[Version(100794368u)]
	public sealed class BasicProperties : IBasicProperties, IStorageItemExtraProperties
	{
		public extern DateTime DateModified
		{
			get;
		}
		public extern DateTime ItemDate
		{
			get;
		}
		public extern ulong Size
		{
			get;
		}
		public extern IAsyncOperation<IMap<string, object>> RetrievePropertiesAsync([In] IIterable<string> propertiesToRetrieve);
		[Overload("SavePropertiesAsync")]
		public extern IAsyncAction SavePropertiesAsync([HasVariant] [In] IIterable<IKeyValuePair<string, object>> propertiesToSave);
		[Overload("SavePropertiesAsyncOverloadDefault")]
		public extern IAsyncAction SavePropertiesAsync();
	}
}
