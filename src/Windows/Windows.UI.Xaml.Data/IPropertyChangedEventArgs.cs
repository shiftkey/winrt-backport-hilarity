using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Data
{
	[ExclusiveTo(typeof(PropertyChangedEventArgs)), Guid(1328785824u, 23796, 18340, 177, 111, 215, 250, 175, 23, 69, 126), Version(100794368u), WebHostHidden]
	internal interface IPropertyChangedEventArgs
	{
		string PropertyName
		{
			get;
		}
	}
}
