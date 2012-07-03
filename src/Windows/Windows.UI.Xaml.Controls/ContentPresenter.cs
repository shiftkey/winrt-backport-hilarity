using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(IContentPresenterFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IContentPresenterStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Content")]
	public class ContentPresenter : FrameworkElement, IContentPresenter, IContentPresenterOverrides
	{
		public extern int CharacterSpacing
		{
			get;
			set;
		}
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
		public extern FontFamily FontFamily
		{
			get;
			set;
		}
		public extern double FontSize
		{
			get;
			set;
		}
		public extern FontStretch FontStretch
		{
			get;
			set;
		}
		public extern FontStyle FontStyle
		{
			get;
			set;
		}
		public extern FontWeight FontWeight
		{
			get;
			set;
		}
		public extern Brush Foreground
		{
			get;
			set;
		}
		public static extern DependencyProperty CharacterSpacingProperty
		{
			get;
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
		public static extern DependencyProperty FontFamilyProperty
		{
			get;
		}
		public static extern DependencyProperty FontSizeProperty
		{
			get;
		}
		public static extern DependencyProperty FontStretchProperty
		{
			get;
		}
		public static extern DependencyProperty FontStyleProperty
		{
			get;
		}
		public static extern DependencyProperty FontWeightProperty
		{
			get;
		}
		public static extern DependencyProperty ForegroundProperty
		{
			get;
		}
		public extern ContentPresenter();
		protected virtual extern void OnContentTemplateChanged([In] DataTemplate oldContentTemplate, [In] DataTemplate newContentTemplate);
		protected virtual extern void OnContentTemplateSelectorChanged([In] DataTemplateSelector oldContentTemplateSelector, [In] DataTemplateSelector newContentTemplateSelector);
	}
}
