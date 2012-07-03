using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Hosting
{
	[Guid(2868610253u, 40813, 20352, 172, 44, 14, 108, 185, 243, 22, 89), Version(100794368u), WebHostHidden]
	public interface IXamlUIPresenterHost
	{
		string ResolveFileResource([In] string path);
	}
}
