using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Markup
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IXamlReaderStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class XamlReader : IXamlReader
	{
		public static extern object Load([In] string xaml);
		public static extern object LoadWithInitialTemplateValidation([In] string xaml);
	}
}
