using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Input
{
	[ExclusiveTo(typeof(InputScopeName)), Guid(1245756242u, 19415, 20052, 134, 23, 28, 218, 138, 30, 218, 127), Version(100794368u), WebHostHidden]
	internal interface IInputScopeNameFactory
	{
		InputScopeName CreateInstance([In] InputScopeNameValue nameValue);
	}
}
