using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(PropertyPath)), Guid(806247818u, 8179, 19756, 149, 236, 39, 248, 29, 235, 172, 184), Version(100794368u), WebHostHidden]
	internal interface IPropertyPath
	{
		string Path
		{
			get;
		}
	}
}
