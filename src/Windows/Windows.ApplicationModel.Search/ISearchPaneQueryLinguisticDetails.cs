using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Search
{
	[ExclusiveTo(typeof(SearchPaneQueryLinguisticDetails)), Guid(2197505550u, 2368, 19309, 184, 208, 100, 43, 48, 152, 158, 21), Version(100794368u)]
	internal interface ISearchPaneQueryLinguisticDetails
	{
		IVectorView<string> QueryTextAlternatives
		{
			get;
		}
		uint QueryTextCompositionLength
		{
			get;
		}
		uint QueryTextCompositionStart
		{
			get;
		}
	}
}
