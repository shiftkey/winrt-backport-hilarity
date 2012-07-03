using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Documents
{
	[ExclusiveTo(typeof(Inline)), Guid(1079553233u, 12176, 19343, 153, 221, 66, 24, 239, 95, 3, 222), Version(100794368u), WebHostHidden]
	internal interface IInlineFactory
	{
		Inline CreateInstance([In] object outer, out object inner);
	}
}
