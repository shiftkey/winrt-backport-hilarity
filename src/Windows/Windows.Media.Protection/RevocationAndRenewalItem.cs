using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Protection
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class RevocationAndRenewalItem : IRevocationAndRenewalItem
	{
		public extern string HeaderHash
		{
			get;
		}
		public extern string Name
		{
			get;
		}
		public extern string PublicKeyHash
		{
			get;
		}
		public extern RevocationAndRenewalReasons Reasons
		{
			get;
		}
		public extern string RenewalId
		{
			get;
		}
	}
}
