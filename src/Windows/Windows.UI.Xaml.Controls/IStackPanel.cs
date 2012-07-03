using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(StackPanel)), Guid(3098447842u, 54849, 20439, 128, 180, 116, 57, 32, 125, 39, 152), Version(100794368u), WebHostHidden]
	internal interface IStackPanel
	{
		bool AreScrollSnapPointsRegular
		{
			get;
			set;
		}
		Orientation Orientation
		{
			get;
			set;
		}
	}
}
