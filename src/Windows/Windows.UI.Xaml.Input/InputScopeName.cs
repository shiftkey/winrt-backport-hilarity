using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
namespace Windows.UI.Xaml.Input
{
	[Activatable(100794368u), Activatable(typeof(IInputScopeNameFactory), 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "NameValue")]
	public sealed class InputScopeName : DependencyObject, IInputScopeName
	{
		public extern InputScopeNameValue NameValue
		{
			get;
			set;
		}
		public extern InputScopeName();
		public extern InputScopeName([In] InputScopeNameValue nameValue);
	}
}
