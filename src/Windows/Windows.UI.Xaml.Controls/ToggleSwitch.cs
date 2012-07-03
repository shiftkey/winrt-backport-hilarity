using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Markup;
namespace Windows.UI.Xaml.Controls
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IToggleSwitchStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Header")]
	public sealed class ToggleSwitch : Control, IToggleSwitch, IToggleSwitchOverrides
	{
		public extern event RoutedEventHandler Toggled
		{
			add;
			remove;
		}
		public extern object Header
		{
			get;
			set;
		}
		public extern DataTemplate HeaderTemplate
		{
			get;
			set;
		}
		public extern bool IsOn
		{
			get;
			set;
		}
		public extern object OffContent
		{
			get;
			set;
		}
		public extern DataTemplate OffContentTemplate
		{
			get;
			set;
		}
		public extern object OnContent
		{
			get;
			set;
		}
		public extern DataTemplate OnContentTemplate
		{
			get;
			set;
		}
		public extern ToggleSwitchTemplateSettings TemplateSettings
		{
			get;
		}
		public static extern DependencyProperty HeaderProperty
		{
			get;
		}
		public static extern DependencyProperty HeaderTemplateProperty
		{
			get;
		}
		public static extern DependencyProperty IsOnProperty
		{
			get;
		}
		public static extern DependencyProperty OffContentProperty
		{
			get;
		}
		public static extern DependencyProperty OffContentTemplateProperty
		{
			get;
		}
		public static extern DependencyProperty OnContentProperty
		{
			get;
		}
		public static extern DependencyProperty OnContentTemplateProperty
		{
			get;
		}
		public extern ToggleSwitch();
		protected virtual extern void OnToggled();
		protected virtual extern void OnOnContentChanged([In] object oldContent, [In] object newContent);
		protected virtual extern void OnOffContentChanged([In] object oldContent, [In] object newContent);
		protected virtual extern void OnHeaderChanged([In] object oldContent, [In] object newContent);
	}
}
