using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.ApplicationModel.Activation
{
	[Guid(3140156467u, 37809, 17133, 139, 38, 35, 109, 217, 199, 132, 150), Version(100794368u)]
	public interface IFileActivatedEventArgs : IActivatedEventArgs
	{
		IVectorView<IStorageItem> Files
		{
			get;
		}
		string Verb
		{
			get;
		}
	}
}
