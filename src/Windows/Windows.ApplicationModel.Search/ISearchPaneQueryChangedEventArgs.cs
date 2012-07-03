using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Search
{
	[Guid(1007046633u, 9041, 16968, 165, 41, 113, 16, 244, 100, 167, 133), Version(100794368u)]
	public interface ISearchPaneQueryChangedEventArgs
	{
		string Language
		{
			get;
		}
		SearchPaneQueryLinguisticDetails LinguisticDetails
		{
			get;
		}
		string QueryText
		{
			get;
		}
	}
}
