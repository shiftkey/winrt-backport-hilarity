using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ControlTemplate)), Guid(4023533966u, 16864, 18619, 139, 130, 145, 237, 161, 186, 63, 226), Version(100794368u), WebHostHidden]
	internal interface IControlTemplate
	{
		TypeName TargetType
		{
			get;
			set;
		}
	}
}
