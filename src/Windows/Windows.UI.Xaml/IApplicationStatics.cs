using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(Application)), Guid(105486743u, 63412, 17918, 183, 99, 117, 119, 209, 211, 203, 74), Version(100794368u), WebHostHidden]
	internal interface IApplicationStatics
	{
		Application Current
		{
			get;
		}
		void Start([In] ApplicationInitializationCallback callback);
		[DefaultOverload, Overload("LoadComponent")]
		void LoadComponent([In] object component, [In] Uri resourceLocator);
		[Overload("LoadComponentWithResourceLocation")]
		void LoadComponent([In] object component, [In] Uri resourceLocator, [In] ComponentResourceLocation componentResourceLocation);
	}
}
