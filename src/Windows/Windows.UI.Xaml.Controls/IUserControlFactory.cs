using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(UserControl)), Guid(951184786u, 41610, 18802, 147, 223, 244, 247, 89, 184, 175, 210), Version(100794368u), WebHostHidden]
	internal interface IUserControlFactory
	{
		UserControl CreateInstance([In] object outer, out object inner);
	}
}
