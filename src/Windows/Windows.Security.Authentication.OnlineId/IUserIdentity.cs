using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Security.Authentication.OnlineId
{
	[ExclusiveTo(typeof(UserIdentity)), Guid(558291405u, 1858, 19427, 138, 28, 124, 122, 230, 121, 170, 136), Version(100794368u)]
	internal interface IUserIdentity
	{
		string FirstName
		{
			get;
		}
		string Id
		{
			get;
		}
		bool IsBetaAccount
		{
			get;
		}
		bool IsConfirmedPC
		{
			get;
		}
		string LastName
		{
			get;
		}
		string SafeCustomerId
		{
			get;
		}
		string SignInName
		{
			get;
		}
		IVectorView<OnlineIdServiceTicket> Tickets
		{
			get;
		}
	}
}
