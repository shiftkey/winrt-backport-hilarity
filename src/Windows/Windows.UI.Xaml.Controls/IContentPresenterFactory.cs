using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ContentPresenter)), Guid(859428087u, 18453, 17604, 159, 118, 104, 200, 56, 128, 239, 16), Version(100794368u), WebHostHidden]
	internal interface IContentPresenterFactory
	{
		ContentPresenter CreateInstance([In] object outer, out object inner);
	}
}
