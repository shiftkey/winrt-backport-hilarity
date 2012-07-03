using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Pickers
{
	[Version(100794368u)]
	public sealed class FilePickerSelectedFilesArray : IVectorView<StorageFile>, IIterable<StorageFile>
	{
		public extern uint Size
		{
			get;
		}
		public extern StorageFile GetAt([In] uint index);
		public extern bool IndexOf([In] StorageFile value, out uint index);
		public extern uint GetMany([In] uint startIndex, [Out] StorageFile[] items);
		public extern IIterator<StorageFile> First();
	}
}
