using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Security.Authentication.OnlineId
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class UserIdentity : IUserIdentity
	{
		public extern string FirstName
		{
			get;
		}
		public extern string Id
		{
			get;
		}
		public extern bool IsBetaAccount
		{
			get;
		}
		public extern bool IsConfirmedPC
		{
			get;
		}
		public extern string LastName
		{
			get;
		}
		public extern string SafeCustomerId
		{
			get;
		}
		public extern string SignInName
		{
			get;
		}
		public extern IVectorView<OnlineIdServiceTicket> Tickets
		{
			get;
		}
	}
}
