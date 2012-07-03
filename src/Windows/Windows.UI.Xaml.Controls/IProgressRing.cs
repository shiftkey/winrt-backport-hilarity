using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ProgressRing)), Guid(1839588510u, 28317, 16988, 189, 124, 2, 23, 62, 57, 118, 63), Version(100794368u), WebHostHidden]
	internal interface IProgressRing
	{
		bool IsActive
		{
			get;
			set;
		}
		ProgressRingTemplateSettings TemplateSettings
		{
			get;
		}
	}
}
