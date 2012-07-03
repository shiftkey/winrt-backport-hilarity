using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Text
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IFontWeightsStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class FontWeights : IFontWeights
	{
		public static extern FontWeight Black
		{
			get;
		}
		public static extern FontWeight Bold
		{
			get;
		}
		public static extern FontWeight ExtraBlack
		{
			get;
		}
		public static extern FontWeight ExtraBold
		{
			get;
		}
		public static extern FontWeight ExtraLight
		{
			get;
		}
		public static extern FontWeight Light
		{
			get;
		}
		public static extern FontWeight Medium
		{
			get;
		}
		public static extern FontWeight Normal
		{
			get;
		}
		public static extern FontWeight SemiBold
		{
			get;
		}
		public static extern FontWeight SemiLight
		{
			get;
		}
		public static extern FontWeight Thin
		{
			get;
		}
	}
}
