using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Input
{
	[ExclusiveTo(typeof(InputScopeName)), Guid(4248725911u, 2299, 19642, 160, 33, 121, 45, 117, 137, 253, 90), Version(100794368u), WebHostHidden]
	internal interface IInputScopeName
	{
		InputScopeNameValue NameValue
		{
			get;
			set;
		}
	}
}
