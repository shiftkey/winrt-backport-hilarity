using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[ExclusiveTo(typeof(ValuePatternIdentifiers)), Guid(3259492599u, 44492, 17423, 177, 35, 51, 120, 138, 64, 82, 90), Version(100794368u), WebHostHidden]
	internal interface IValuePatternIdentifiersStatics
	{
		AutomationProperty IsReadOnlyProperty
		{
			get;
		}
		AutomationProperty ValueProperty
		{
			get;
		}
	}
}
