using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(Window)), Guid(846599805u, 51702, 17965, 157, 226, 174, 76, 31, 216, 194, 229), Version(100794368u), WebHostHidden]
	internal interface IWindow
	{
		event WindowActivatedEventHandler Activated;
		event WindowClosedEventHandler Closed;
		event WindowSizeChangedEventHandler SizeChanged;
		event WindowVisibilityChangedEventHandler VisibilityChanged;
		Rect Bounds
		{
			get;
		}
		UIElement Content
		{
			get;
			set;
		}
		CoreWindow CoreWindow
		{
			get;
		}
		CoreDispatcher Dispatcher
		{
			get;
		}
		bool Visible
		{
			get;
		}
		void Activate();
		void Close();
	}
}
