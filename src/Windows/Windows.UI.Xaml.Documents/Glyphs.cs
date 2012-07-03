using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Documents
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IGlyphsStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class Glyphs : FrameworkElement, IGlyphs
	{
		public extern Brush Fill
		{
			get;
			set;
		}
		public extern double FontRenderingEmSize
		{
			get;
			set;
		}
		public extern Uri FontUri
		{
			get;
			set;
		}
		public extern string Indices
		{
			get;
			set;
		}
		public extern double OriginX
		{
			get;
			set;
		}
		public extern double OriginY
		{
			get;
			set;
		}
		public extern StyleSimulations StyleSimulations
		{
			get;
			set;
		}
		public extern string UnicodeString
		{
			get;
			set;
		}
		public static extern DependencyProperty FillProperty
		{
			get;
		}
		public static extern DependencyProperty FontRenderingEmSizeProperty
		{
			get;
		}
		public static extern DependencyProperty FontUriProperty
		{
			get;
		}
		public static extern DependencyProperty IndicesProperty
		{
			get;
		}
		public static extern DependencyProperty OriginXProperty
		{
			get;
		}
		public static extern DependencyProperty OriginYProperty
		{
			get;
		}
		public static extern DependencyProperty StyleSimulationsProperty
		{
			get;
		}
		public static extern DependencyProperty UnicodeStringProperty
		{
			get;
		}
		public extern Glyphs();
	}
}
