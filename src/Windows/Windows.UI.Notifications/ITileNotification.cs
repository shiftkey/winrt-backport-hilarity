using System;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[ExclusiveTo(typeof(TileNotification)), Guid(3954100474u, 20716, 19480, 180, 208, 58, 240, 46, 85, 64, 171), Version(100794368u)]
	internal interface ITileNotification
	{
		XmlDocument Content
		{
			get;
		}
		IReference<DateTime> ExpirationTime
		{
			get;
			set;
		}
		string Tag
		{
			get;
			set;
		}
	}
}
