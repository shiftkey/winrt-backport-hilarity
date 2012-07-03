using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Provider
{
	[Guid(1236042649u, 54822, 17731, 148, 185, 166, 217, 169, 89, 58, 246), Version(100794368u), WebHostHidden]
	public interface IExpandCollapseProvider
	{
		ExpandCollapseState ExpandCollapseState
		{
			get;
		}
		void Collapse();
		void Expand();
	}
}
