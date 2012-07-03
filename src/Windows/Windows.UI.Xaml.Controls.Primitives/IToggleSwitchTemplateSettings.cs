using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(ToggleSwitchTemplateSettings)), Guid(45596109u, 25226, 17251, 134, 224, 81, 214, 226, 232, 158, 88), Version(100794368u), WebHostHidden]
	internal interface IToggleSwitchTemplateSettings
	{
		double CurtainCurrentToOffOffset
		{
			get;
		}
		double CurtainCurrentToOnOffset
		{
			get;
		}
		double CurtainOffToOnOffset
		{
			get;
		}
		double CurtainOnToOffOffset
		{
			get;
		}
		double KnobCurrentToOffOffset
		{
			get;
		}
		double KnobCurrentToOnOffset
		{
			get;
		}
		double KnobOffToOnOffset
		{
			get;
		}
		double KnobOnToOffOffset
		{
			get;
		}
	}
}
