using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Documents
{
	[ExclusiveTo(typeof(InlineUIContainer)), Guid(337038977u, 10478, 17710, 177, 33, 95, 196, 246, 11, 134, 166), Version(100794368u), WebHostHidden]
	internal interface IInlineUIContainer
	{
		UIElement Child
		{
			get;
			set;
		}
	}
}
