using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Documents
{
	[ExclusiveTo(typeof(Paragraph)), Guid(4164875674u, 64097, 19439, 174, 51, 11, 10, 215, 86, 168, 77), Version(100794368u), WebHostHidden]
	internal interface IParagraph
	{
		InlineCollection Inlines
		{
			get;
		}
	}
}
