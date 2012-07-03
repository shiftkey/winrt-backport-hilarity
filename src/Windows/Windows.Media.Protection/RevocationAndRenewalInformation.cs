using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Media.Protection
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class RevocationAndRenewalInformation : IRevocationAndRenewalInformation
	{
		public extern IVector<RevocationAndRenewalItem> Items
		{
			get;
		}
	}
}
