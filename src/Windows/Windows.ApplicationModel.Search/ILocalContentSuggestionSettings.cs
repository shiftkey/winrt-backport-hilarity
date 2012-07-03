using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.ApplicationModel.Search
{
	[ExclusiveTo(typeof(LocalContentSuggestionSettings)), Guid(4004425826u, 29757, 17774, 132, 163, 35, 240, 111, 45, 21, 215), Version(100794368u)]
	internal interface ILocalContentSuggestionSettings
	{
		string AqsFilter
		{
			get;
			set;
		}
		bool Enabled
		{
			get;
			set;
		}
		IVector<StorageFolder> Locations
		{
			get;
		}
		IVector<string> PropertiesToMatch
		{
			get;
		}
	}
}
