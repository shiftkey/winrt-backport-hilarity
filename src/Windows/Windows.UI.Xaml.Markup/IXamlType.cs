using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
namespace Windows.UI.Xaml.Markup
{
	[Guid(2032200369u, 41701, 18330, 189, 80, 108, 239, 60, 11, 73, 112), Version(100794368u), WebHostHidden]
	public interface IXamlType
	{
		IXamlType BaseType
		{
			get;
		}
		IXamlMember ContentProperty
		{
			get;
		}
		string FullName
		{
			get;
		}
		bool IsArray
		{
			get;
		}
		bool IsBindable
		{
			get;
		}
		bool IsCollection
		{
			get;
		}
		bool IsConstructible
		{
			get;
		}
		bool IsDictionary
		{
			get;
		}
		bool IsMarkupExtension
		{
			get;
		}
		IXamlType ItemType
		{
			get;
		}
		IXamlType KeyType
		{
			get;
		}
		TypeName UnderlyingType
		{
			get;
		}
		object ActivateInstance();
		object CreateFromString([In] string value);
		IXamlMember GetMember([In] string name);
		void AddToVector([In] object instance, [In] object value);
		void AddToMap([In] object instance, [In] object key, [In] object value);
		void RunInitializer();
	}
}
