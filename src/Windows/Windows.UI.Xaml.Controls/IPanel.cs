using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Panel)), Guid(2768915389u, 33633, 18076, 144, 218, 233, 164, 12, 116, 116, 223), Version(100794368u), WebHostHidden]
	internal interface IPanel
	{
		Brush Background
		{
			get;
			set;
		}
		UIElementCollection Children
		{
			get;
		}
		TransitionCollection ChildrenTransitions
		{
			get;
			set;
		}
		bool IsItemsHost
		{
			get;
		}
	}
}
