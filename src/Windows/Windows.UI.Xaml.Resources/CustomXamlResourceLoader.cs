using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Resources
{
	[Composable(typeof(ICustomXamlResourceLoaderFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ICustomXamlResourceLoaderStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class CustomXamlResourceLoader : ICustomXamlResourceLoader, ICustomXamlResourceLoaderOverrides
	{
		public static extern CustomXamlResourceLoader Current
		{
			get;
			set;
		}
		public extern CustomXamlResourceLoader();
		protected virtual extern object GetResource([In] string resourceId, [In] string objectType, [In] string propertyName, [In] string propertyType);
	}
}
