using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(ResourceDictionary)), Guid(3253358372u, 55006, 16785, 142, 58, 244, 134, 1, 247, 72, 156), Version(100794368u), WebHostHidden]
	internal interface IResourceDictionary
	{
		IVector<ResourceDictionary> MergedDictionaries
		{
			get;
		}
		Uri Source
		{
			get;
			set;
		}
		IMap<object, object> ThemeDictionaries
		{
			get;
		}
	}
}
