using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(GeneratorPositionHelper)), Guid(2906691021u, 24812, 17800, 141, 96, 57, 210, 144, 151, 164, 223), Version(100794368u), WebHostHidden]
	internal interface IGeneratorPositionHelperStatics
	{
		GeneratorPosition FromIndexAndOffset([In] int index, [In] int offset);
	}
}
