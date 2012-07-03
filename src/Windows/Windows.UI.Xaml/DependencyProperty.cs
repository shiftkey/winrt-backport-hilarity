using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
namespace Windows.UI.Xaml
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IDependencyPropertyStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class DependencyProperty : IDependencyProperty
	{
		public static extern object UnsetValue
		{
			get;
		}
		public extern PropertyMetadata GetMetadata([In] TypeName forType);
		public static extern DependencyProperty Register([In] string name, [In] TypeName propertyType, [In] TypeName ownerType, [In] PropertyMetadata typeMetadata);
		public static extern DependencyProperty RegisterAttached([In] string name, [In] TypeName propertyType, [In] TypeName ownerType, [In] PropertyMetadata defaultMetadata);
	}
}
