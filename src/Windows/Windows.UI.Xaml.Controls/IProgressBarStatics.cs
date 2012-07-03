using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ProgressBar)), Guid(2048040922u, 22583, 20006, 179, 180, 225, 192, 146, 206, 187, 236), Version(100794368u), WebHostHidden]
	internal interface IProgressBarStatics
	{
		DependencyProperty IsIndeterminateProperty
		{
			get;
		}
		DependencyProperty ShowErrorProperty
		{
			get;
		}
		DependencyProperty ShowPausedProperty
		{
			get;
		}
	}
}
