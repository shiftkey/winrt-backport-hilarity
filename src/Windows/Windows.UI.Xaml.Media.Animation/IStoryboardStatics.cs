using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(Storyboard)), Guid(3626960856u, 29653, 17273, 189, 72, 126, 5, 24, 74, 139, 173), Version(100794368u), WebHostHidden]
	internal interface IStoryboardStatics
	{
		DependencyProperty TargetNameProperty
		{
			get;
		}
		DependencyProperty TargetPropertyProperty
		{
			get;
		}
		string GetTargetProperty([In] Timeline element);
		void SetTargetProperty([In] Timeline element, [In] string path);
		string GetTargetName([In] Timeline element);
		void SetTargetName([In] Timeline element, [In] string name);
		void SetTarget([In] Timeline timeline, [In] DependencyObject target);
	}
}
