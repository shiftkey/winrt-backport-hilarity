using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Documents
{
	[Composable(typeof(IBlockFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IBlockStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class Block : TextElement, IBlock
	{
		public extern double LineHeight
		{
			get;
			set;
		}
		public extern LineStackingStrategy LineStackingStrategy
		{
			get;
			set;
		}
		public extern TextAlignment TextAlignment
		{
			get;
			set;
		}
		public static extern DependencyProperty LineHeightProperty
		{
			get;
		}
		public static extern DependencyProperty LineStackingStrategyProperty
		{
			get;
		}
		public static extern DependencyProperty TextAlignmentProperty
		{
			get;
		}
		protected extern Block();
	}
}
