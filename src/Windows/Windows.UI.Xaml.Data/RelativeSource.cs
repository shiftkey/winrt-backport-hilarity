using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Data
{
	[Composable(typeof(IRelativeSourceFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class RelativeSource : DependencyObject, IRelativeSource
	{
		public extern RelativeSourceMode Mode
		{
			get;
			set;
		}
		public extern RelativeSource();
	}
}
