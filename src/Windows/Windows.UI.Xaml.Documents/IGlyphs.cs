using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Documents
{
	[ExclusiveTo(typeof(Glyphs)), Guid(3497609611u, 62129, 17025, 153, 162, 228, 208, 89, 50, 178, 181), Version(100794368u), WebHostHidden]
	internal interface IGlyphs
	{
		Brush Fill
		{
			get;
			set;
		}
		double FontRenderingEmSize
		{
			get;
			set;
		}
		Uri FontUri
		{
			get;
			set;
		}
		string Indices
		{
			get;
			set;
		}
		double OriginX
		{
			get;
			set;
		}
		double OriginY
		{
			get;
			set;
		}
		StyleSimulations StyleSimulations
		{
			get;
			set;
		}
		string UnicodeString
		{
			get;
			set;
		}
	}
}
