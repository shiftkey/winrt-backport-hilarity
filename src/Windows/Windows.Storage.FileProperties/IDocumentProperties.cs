using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.FileProperties
{
	[ExclusiveTo(typeof(DocumentProperties)), Guid(2125142460u, 6177, 18723, 180, 169, 10, 234, 64, 77, 0, 112), Version(100794368u)]
	internal interface IDocumentProperties : IStorageItemExtraProperties
	{
		IVector<string> Author
		{
			get;
		}
		string Comment
		{
			get;
			set;
		}
		IVector<string> Keywords
		{
			get;
		}
		string Title
		{
			get;
			set;
		}
	}
}
