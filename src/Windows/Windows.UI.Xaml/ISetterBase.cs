using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(SetterBase)), Guid(1099686524u, 10948, 20258, 128, 151, 222, 163, 174, 235, 47, 179), Version(100794368u), WebHostHidden]
	internal interface ISetterBase
	{
		bool IsSealed
		{
			get;
		}
	}
}
