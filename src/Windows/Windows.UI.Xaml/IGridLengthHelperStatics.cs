using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(GridLengthHelper)), Guid(2638576539u, 415, 16998, 136, 114, 33, 95, 25, 143, 106, 157), Version(100794368u), WebHostHidden]
	internal interface IGridLengthHelperStatics
	{
		GridLength Auto
		{
			get;
		}
		GridLength FromPixels([In] double pixels);
		GridLength FromValueAndType([In] double value, [In] GridUnitType type);
		bool GetIsAbsolute([In] GridLength target);
		bool GetIsAuto([In] GridLength target);
		bool GetIsStar([In] GridLength target);
		bool Equals([In] GridLength target, [In] GridLength value);
	}
}
