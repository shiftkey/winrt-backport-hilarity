using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.ApplicationModel.Resources.Core
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class ResourceCandidate : IResourceCandidate
	{
		public extern bool IsDefault
		{
			get;
		}
		public extern bool IsMatch
		{
			get;
		}
		public extern bool IsMatchAsDefault
		{
			get;
		}
		public extern IVectorView<ResourceQualifier> Qualifiers
		{
			get;
		}
		public extern string ValueAsString
		{
			get;
		}
		public extern IAsyncOperation<StorageFile> GetValueAsFileAsync();
		public extern string GetQualifierValue([In] string qualifierName);
	}
}
