using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(RowDefinition)), Guid(1253763113u, 55308, 19038, 164, 140, 248, 179, 211, 182, 83, 61), Version(100794368u), WebHostHidden]
	internal interface IRowDefinition
	{
		double ActualHeight
		{
			get;
		}
		GridLength Height
		{
			get;
			set;
		}
		double MaxHeight
		{
			get;
			set;
		}
		double MinHeight
		{
			get;
			set;
		}
	}
}
