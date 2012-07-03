using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Markup
{
	[ExclusiveTo(typeof(XamlReader)), Guid(2559690429u, 21327, 18773, 184, 90, 138, 141, 192, 220, 166, 2), Version(100794368u), WebHostHidden]
	internal interface IXamlReaderStatics
	{
		object Load([In] string xaml);
		object LoadWithInitialTemplateValidation([In] string xaml);
	}
}
