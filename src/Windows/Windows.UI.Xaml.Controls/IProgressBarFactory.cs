using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ProgressBar)), Guid(3667561489u, 5521, 16395, 169, 147, 15, 28, 92, 193, 47, 59), Version(100794368u), WebHostHidden]
	internal interface IProgressBarFactory
	{
		ProgressBar CreateInstance([In] object outer, out object inner);
	}
}
