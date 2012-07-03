using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[ExclusiveTo(typeof(DropTargetPatternIdentifiers)), Guid(459879172u, 35323, 19210, 148, 82, 202, 44, 102, 170, 249, 243), Version(100794368u), WebHostHidden]
	internal interface IDropTargetPatternIdentifiersStatics
	{
		AutomationProperty DropTargetEffectProperty
		{
			get;
		}
		AutomationProperty DropTargetEffectsProperty
		{
			get;
		}
	}
}
