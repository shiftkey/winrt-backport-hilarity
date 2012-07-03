using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Shapes
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ILineStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class Line : Shape, ILine
	{
		public extern double X1
		{
			get;
			set;
		}
		public extern double X2
		{
			get;
			set;
		}
		public extern double Y1
		{
			get;
			set;
		}
		public extern double Y2
		{
			get;
			set;
		}
		public static extern DependencyProperty X1Property
		{
			get;
		}
		public static extern DependencyProperty X2Property
		{
			get;
		}
		public static extern DependencyProperty Y1Property
		{
			get;
		}
		public static extern DependencyProperty Y2Property
		{
			get;
		}
		public extern Line();
	}
}
