using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Contacts
{
	[Guid(2977319018u, 53907, 18732, 160, 88, 219, 87, 91, 62, 60, 15), Version(100794368u)]
	public interface IContactField
	{
		ContactFieldCategory Category
		{
			get;
		}
		string Name
		{
			get;
		}
		ContactFieldType Type
		{
			get;
		}
		string Value
		{
			get;
		}
	}
}
