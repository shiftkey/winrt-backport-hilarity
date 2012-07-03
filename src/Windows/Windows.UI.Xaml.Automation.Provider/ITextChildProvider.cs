using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Provider
{
	[Guid(288604982u, 43163, 16688, 155, 230, 85, 227, 51, 52, 245, 87), Version(100794368u), WebHostHidden]
	public interface ITextChildProvider
	{
		IRawElementProviderSimple TextContainer
		{
			get;
		}
		ITextRangeProvider TextRange
		{
			get;
		}
	}
}
