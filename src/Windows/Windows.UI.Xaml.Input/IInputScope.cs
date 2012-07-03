using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Input
{
	[ExclusiveTo(typeof(InputScope)), Guid(1544521203u, 63960, 16928, 182, 102, 4, 93, 7, 77, 155, 250), Version(100794368u), WebHostHidden]
	internal interface IInputScope
	{
		IVector<InputScopeName> Names
		{
			get;
		}
	}
}
