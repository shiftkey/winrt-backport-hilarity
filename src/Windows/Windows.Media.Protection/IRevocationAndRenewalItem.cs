using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Protection
{
	[ExclusiveTo(typeof(RevocationAndRenewalItem)), Guid(815383052u, 15600, 18922, 144, 45, 202, 243, 45, 45, 222, 44), Version(100794368u)]
	internal interface IRevocationAndRenewalItem
	{
		string HeaderHash
		{
			get;
		}
		string Name
		{
			get;
		}
		string PublicKeyHash
		{
			get;
		}
		RevocationAndRenewalReasons Reasons
		{
			get;
		}
		string RenewalId
		{
			get;
		}
	}
}
