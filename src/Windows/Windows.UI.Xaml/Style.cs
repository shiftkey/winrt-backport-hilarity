using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
using Windows.UI.Xaml.Markup;
namespace Windows.UI.Xaml
{
	[Activatable(100794368u), Activatable(typeof(IStyleFactory), 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Setters")]
	public sealed class Style : DependencyObject, IStyle
	{
		public extern Style BasedOn
		{
			get;
			set;
		}
		public extern bool IsSealed
		{
			get;
		}
		public extern SetterBaseCollection Setters
		{
			get;
		}
		public extern TypeName TargetType
		{
			get;
			set;
		}
		public extern Style();
		public extern Style([In] TypeName targetType);
		public extern void Seal();
	}
}
