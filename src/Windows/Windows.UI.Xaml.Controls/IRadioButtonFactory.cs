using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(RadioButton)), Guid(4056959283u, 13537, 19036, 178, 174, 202, 59, 28, 11, 32, 222), Version(100794368u), WebHostHidden]
	internal interface IRadioButtonFactory
	{
		RadioButton CreateInstance([In] object outer, out object inner);
	}
}
