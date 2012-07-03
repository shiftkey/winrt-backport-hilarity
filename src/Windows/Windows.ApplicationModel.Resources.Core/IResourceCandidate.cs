using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.ApplicationModel.Resources.Core
{
	[ExclusiveTo(typeof(ResourceCandidate)), Guid(2941388761u, 50227, 18276, 179, 253, 143, 166, 191, 188, 186, 220), Version(100794368u)]
	internal interface IResourceCandidate
	{
		bool IsDefault
		{
			get;
		}
		bool IsMatch
		{
			get;
		}
		bool IsMatchAsDefault
		{
			get;
		}
		IVectorView<ResourceQualifier> Qualifiers
		{
			get;
		}
		string ValueAsString
		{
			get;
		}
		IAsyncOperation<StorageFile> GetValueAsFileAsync();
		string GetQualifierValue([In] string qualifierName);
	}
}
