using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(DataTemplate)), Guid(2568007367u, 35509, 16664, 155, 198, 9, 244, 90, 53, 7, 61), Version(100794368u), WebHostHidden]
	internal interface IDataTemplate
	{
		DependencyObject LoadContent();
	}
}
