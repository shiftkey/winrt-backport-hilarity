using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ITransformGroupStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Children")]
	public sealed class TransformGroup : Transform, ITransformGroup
	{
		public extern TransformCollection Children
		{
			get;
			set;
		}
		public extern Matrix Value
		{
			get;
		}
		public static extern DependencyProperty ChildrenProperty
		{
			get;
		}
		public extern TransformGroup();
	}
}
