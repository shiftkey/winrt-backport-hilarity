using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[Composable(typeof(ITileBrushFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ITileBrushStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class TileBrush : Brush, ITileBrush
	{
		public extern AlignmentX AlignmentX
		{
			get;
			set;
		}
		public extern AlignmentY AlignmentY
		{
			get;
			set;
		}
		public extern Stretch Stretch
		{
			get;
			set;
		}
		public static extern DependencyProperty AlignmentXProperty
		{
			get;
		}
		public static extern DependencyProperty AlignmentYProperty
		{
			get;
		}
		public static extern DependencyProperty StretchProperty
		{
			get;
		}
		protected extern TileBrush();
	}
}
