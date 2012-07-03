using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ProgressBar)), Guid(2926914697u, 103, 18787, 191, 76, 41, 219, 12, 74, 80, 126), Version(100794368u), WebHostHidden]
	internal interface IProgressBar
	{
		bool IsIndeterminate
		{
			get;
			set;
		}
		bool ShowError
		{
			get;
			set;
		}
		bool ShowPaused
		{
			get;
			set;
		}
		ProgressBarTemplateSettings TemplateSettings
		{
			get;
		}
	}
}
