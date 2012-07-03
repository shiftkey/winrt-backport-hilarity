using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Search
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class SearchPaneQueryLinguisticDetails : ISearchPaneQueryLinguisticDetails
	{
		public extern IVectorView<string> QueryTextAlternatives
		{
			get;
		}
		public extern uint QueryTextCompositionLength
		{
			get;
		}
		public extern uint QueryTextCompositionStart
		{
			get;
		}
	}
}
