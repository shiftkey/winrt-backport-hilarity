using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[Activatable(typeof(IPropertyPathFactory), 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class PropertyPath : DependencyObject, IPropertyPath
	{
		public extern string Path
		{
			get;
		}
		public extern PropertyPath([In] string path);
	}
}
