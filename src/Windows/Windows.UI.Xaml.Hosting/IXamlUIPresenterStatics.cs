using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Hosting
{
	[ExclusiveTo(typeof(XamlUIPresenter)), Guid(1911220936u, 17889, 16786, 133, 170, 58, 66, 46, 221, 35, 207), Version(100794368u), WebHostHidden]
	internal interface IXamlUIPresenterStatics
	{
		bool CompleteTimelinesAutomatically
		{
			get;
			set;
		}
		void SetHost([In] IXamlUIPresenterHost host);
		void NotifyWindowSizeChanged();
	}
}
