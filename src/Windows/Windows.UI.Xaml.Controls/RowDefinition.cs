using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IRowDefinitionStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class RowDefinition : DependencyObject, IRowDefinition
	{
		public extern double ActualHeight
		{
			get;
		}
		public extern GridLength Height
		{
			get;
			set;
		}
		public extern double MaxHeight
		{
			get;
			set;
		}
		public extern double MinHeight
		{
			get;
			set;
		}
		public static extern DependencyProperty HeightProperty
		{
			get;
		}
		public static extern DependencyProperty MaxHeightProperty
		{
			get;
		}
		public static extern DependencyProperty MinHeightProperty
		{
			get;
		}
		public extern RowDefinition();
	}
}
