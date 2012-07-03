using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Provider
{
	[Guid(2036797405u, 63145, 19045, 175, 23, 134, 29, 183, 153, 162, 218), Version(100794368u), WebHostHidden]
	public interface ITransformProvider
	{
		bool CanMove
		{
			get;
		}
		bool CanResize
		{
			get;
		}
		bool CanRotate
		{
			get;
		}
		void Move([In] double x, [In] double y);
		void Resize([In] double width, [In] double height);
		void Rotate([In] double degrees);
	}
}
