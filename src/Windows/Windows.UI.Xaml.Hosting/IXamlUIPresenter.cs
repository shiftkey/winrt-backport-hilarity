using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Hosting
{
	[ExclusiveTo(typeof(XamlUIPresenter)), Guid(2803143754u, 5657, 20422, 179, 27, 137, 81, 46, 240, 34, 162), Version(100794368u), WebHostHidden]
	internal interface IXamlUIPresenter
	{
		UIElement RootElement
		{
			get;
			set;
		}
		string ThemeKey
		{
			get;
			set;
		}
		string ThemeResourcesXaml
		{
			get;
			set;
		}
		void SetSize([In] int width, [In] int height);
		void Render();
		void Present();
	}
}
