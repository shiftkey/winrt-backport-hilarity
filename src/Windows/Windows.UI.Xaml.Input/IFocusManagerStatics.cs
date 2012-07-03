using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Input
{
	[ExclusiveTo(typeof(FocusManager)), Guid(516739878u, 33154, 17538, 130, 106, 9, 24, 233, 237, 154, 247), Version(100794368u), WebHostHidden]
	internal interface IFocusManagerStatics
	{
		object GetFocusedElement();
	}
}
