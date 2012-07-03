using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Pickers.Provider
{
	[ExclusiveTo(typeof(FileOpenPickerUI)), Guid(3718535696u, 63956, 16580, 138, 245, 197, 182, 181, 166, 29, 29), Version(100794368u)]
	internal interface IFileOpenPickerUI
	{
		event TypedEventHandler<FileOpenPickerUI, PickerClosingEventArgs> Closing;
		event TypedEventHandler<FileOpenPickerUI, FileRemovedEventArgs> FileRemoved;
		IVectorView<string> AllowedFileTypes
		{
			get;
		}
		FileSelectionMode SelectionMode
		{
			get;
		}
		string SettingsIdentifier
		{
			get;
		}
		string Title
		{
			get;
			set;
		}
		AddFileResult AddFile([In] string id, [In] IStorageFile file);
		void RemoveFile([In] string id);
		bool ContainsFile([In] string id);
		bool CanAddFile([In] IStorageFile file);
	}
}
