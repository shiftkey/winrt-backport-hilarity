using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Devices
{
	[ExclusiveTo(typeof(DialRequestedEventArgs)), Guid(58430110u, 38204, 17030, 136, 102, 79, 15, 55, 108, 133, 90), Version(100794368u)]
	internal interface IDialRequestedEventArgs
	{
		object Contact
		{
			get;
		}
		void Handled();
	}
}
