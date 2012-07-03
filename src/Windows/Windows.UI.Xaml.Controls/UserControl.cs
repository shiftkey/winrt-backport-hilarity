using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(IUserControlFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IUserControlStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Content")]
	public class UserControl : Control, IUserControl
	{
		public extern UIElement Content
		{
			get;
			set;
		}
		public static extern DependencyProperty ContentProperty
		{
			get;
		}
		public extern UserControl();
	}
}
