using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(DataTemplateKey)), Guid(3916114265u, 55682, 16722, 145, 203, 222, 14, 77, 253, 118, 147), Version(100794368u), WebHostHidden]
	internal interface IDataTemplateKeyFactory
	{
		DataTemplateKey CreateInstance([In] object outer, out object inner);
		DataTemplateKey CreateInstanceWithType([In] object dataType, [In] object outer, out object inner);
	}
}
