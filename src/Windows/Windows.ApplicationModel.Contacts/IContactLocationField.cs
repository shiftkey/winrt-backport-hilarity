using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Contacts
{
	[ExclusiveTo(typeof(ContactLocationField)), Guid(2663387010u, 43886, 19254, 137, 227, 178, 59, 192, 161, 218, 204), Version(100794368u)]
	internal interface IContactLocationField : IContactField
	{
		string City
		{
			get;
		}
		string Country
		{
			get;
		}
		string PostalCode
		{
			get;
		}
		string Region
		{
			get;
		}
		string Street
		{
			get;
		}
		string UnstructuredAddress
		{
			get;
		}
	}
}
