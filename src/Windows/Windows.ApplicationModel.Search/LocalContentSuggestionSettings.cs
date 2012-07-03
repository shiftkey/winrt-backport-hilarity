using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.ApplicationModel.Search
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Standard), Version(100794368u)]
	public sealed class LocalContentSuggestionSettings : ILocalContentSuggestionSettings
	{
		public extern string AqsFilter
		{
			get;
			set;
		}
		public extern bool Enabled
		{
			get;
			set;
		}
		public extern IVector<StorageFolder> Locations
		{
			get;
		}
		public extern IVector<string> PropertiesToMatch
		{
			get;
		}
		public extern LocalContentSuggestionSettings();
	}
}
