using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(IContentControlFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IContentControlStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Content")]
	public class ContentControl : Control, IContentControl, IContentControlOverrides
	{
		public extern object Content
		{
			get;
			set;
		}
		public extern DataTemplate ContentTemplate
		{
			get;
			set;
		}
		public extern DataTemplateSelector ContentTemplateSelector
		{
			get;
			set;
		}
		public extern TransitionCollection ContentTransitions
		{
			get;
			set;
		}
		public static extern DependencyProperty ContentProperty
		{
			get;
		}
		public static extern DependencyProperty ContentTemplateProperty
		{
			get;
		}
		public static extern DependencyProperty ContentTemplateSelectorProperty
		{
			get;
		}
		public static extern DependencyProperty ContentTransitionsProperty
		{
			get;
		}
		public extern ContentControl();
		protected virtual extern void OnContentChanged([In] object oldContent, [In] object newContent);
		protected virtual extern void OnContentTemplateChanged([In] DataTemplate oldContentTemplate, [In] DataTemplate newContentTemplate);
		protected virtual extern void OnContentTemplateSelectorChanged([In] DataTemplateSelector oldContentTemplateSelector, [In] DataTemplateSelector newContentTemplateSelector);
	}
}
