using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Pickers.Provider
{
	[Version(100794368u)]
	public sealed class FileOpenPickerUI : IFileOpenPickerUI
	{
		public extern event TypedEventHandler<FileOpenPickerUI, PickerClosingEventArgs> Closing
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<FileOpenPickerUI, FileRemovedEventArgs> FileRemoved
		{
			add;
			remove;
		}
		public extern IVectorView<string> AllowedFileTypes
		{
			get;
		}
		public extern FileSelectionMode SelectionMode
		{
			get;
		}
		public extern string SettingsIdentifier
		{
			get;
		}
		public extern string Title
		{
			get;
			set;
		}
		public extern AddFileResult AddFile([In] string id, [In] IStorageFile file);
		public extern void RemoveFile([In] string id);
		public extern bool ContainsFile([In] string id);
		public extern bool CanAddFile([In] IStorageFile file);
	}
}
