using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Documents
{
	[ExclusiveTo(typeof(Span)), Guid(2553926825u, 687, 18449, 170, 21, 107, 239, 58, 202, 201, 122), Version(100794368u), WebHostHidden]
	internal interface ISpan
	{
		InlineCollection Inlines
		{
			get;
			set;
		}
	}
}
