using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Version(100794368u), WebHostHidden]
	public enum AutomationEvents
	{
		ToolTipOpened,
		ToolTipClosed,
		MenuOpened,
		MenuClosed,
		AutomationFocusChanged,
		InvokePatternOnInvoked,
		SelectionItemPatternOnElementAddedToSelection,
		SelectionItemPatternOnElementRemovedFromSelection,
		SelectionItemPatternOnElementSelected,
		SelectionPatternOnInvalidated,
		TextPatternOnTextSelectionChanged,
		TextPatternOnTextChanged,
		AsyncContentLoaded,
		PropertyChanged,
		StructureChanged,
		DragStart,
		DragCancel,
		DragComplete,
		DragEnter,
		DragLeave,
		Dropped
	}
}
