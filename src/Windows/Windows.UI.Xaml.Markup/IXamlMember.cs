using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Markup
{
	[Guid(3309434252u, 17321, 16918, 183, 24, 224, 177, 27, 20, 233, 62), Version(100794368u), WebHostHidden]
	public interface IXamlMember
	{
		bool IsAttachable
		{
			get;
		}
		bool IsDependencyProperty
		{
			get;
		}
		bool IsReadOnly
		{
			get;
		}
		string Name
		{
			get;
		}
		IXamlType TargetType
		{
			get;
		}
		IXamlType Type
		{
			get;
		}
		object GetValue([In] object instance);
		void SetValue([In] object instance, [In] object value);
	}
}
