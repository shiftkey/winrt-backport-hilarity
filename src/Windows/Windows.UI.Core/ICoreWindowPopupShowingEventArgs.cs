using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[ExclusiveTo(typeof(CoreWindowPopupShowingEventArgs)), Guid(638934946u, 23461, 20132, 163, 180, 45, 199, 214, 60, 142, 38), Version(100794368u), WebHostHidden]
	internal interface ICoreWindowPopupShowingEventArgs
	{
		void SetDesiredSize([In] Size value);
	}
}
