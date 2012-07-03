using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(ToolTipTemplateSettings)), Guid(3560473159u, 3780, 17670, 175, 253, 175, 172, 34, 37, 180, 140), Version(100794368u), WebHostHidden]
	internal interface IToolTipTemplateSettings
	{
		double FromHorizontalOffset
		{
			get;
		}
		double FromVerticalOffset
		{
			get;
		}
	}
}
