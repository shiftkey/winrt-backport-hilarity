using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Documents
{
	[ExclusiveTo(typeof(Glyphs)), Guid(576517317u, 65009, 17389, 149, 143, 65, 78, 134, 241, 3, 242), Version(100794368u), WebHostHidden]
	internal interface IGlyphsStatics
	{
		DependencyProperty FillProperty
		{
			get;
		}
		DependencyProperty FontRenderingEmSizeProperty
		{
			get;
		}
		DependencyProperty FontUriProperty
		{
			get;
		}
		DependencyProperty IndicesProperty
		{
			get;
		}
		DependencyProperty OriginXProperty
		{
			get;
		}
		DependencyProperty OriginYProperty
		{
			get;
		}
		DependencyProperty StyleSimulationsProperty
		{
			get;
		}
		DependencyProperty UnicodeStringProperty
		{
			get;
		}
	}
}
