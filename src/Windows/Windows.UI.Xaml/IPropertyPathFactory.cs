using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(PropertyPath)), Guid(1313660825u, 38950, 20054, 132, 124, 202, 5, 95, 22, 41, 5), Version(100794368u), WebHostHidden]
	internal interface IPropertyPathFactory
	{
		PropertyPath CreateInstance([In] string path);
	}
}
