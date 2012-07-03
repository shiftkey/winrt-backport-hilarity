using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(DataTemplateKey)), Guid(2268818472u, 52459, 19297, 134, 250, 178, 206, 195, 156, 194, 250), Version(100794368u), WebHostHidden]
	internal interface IDataTemplateKey
	{
		object DataType
		{
			get;
			set;
		}
	}
}
