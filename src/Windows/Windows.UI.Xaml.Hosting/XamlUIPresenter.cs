using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Hosting
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IXamlUIPresenterStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class XamlUIPresenter : IXamlUIPresenter
	{
		public extern UIElement RootElement
		{
			get;
			set;
		}
		public extern string ThemeKey
		{
			get;
			set;
		}
		public extern string ThemeResourcesXaml
		{
			get;
			set;
		}
		public static extern bool CompleteTimelinesAutomatically
		{
			get;
			set;
		}
		public extern void SetSize([In] int width, [In] int height);
		public extern void Render();
		public extern void Present();
		public static extern void SetHost([In] IXamlUIPresenterHost host);
		public static extern void NotifyWindowSizeChanged();
	}
}
