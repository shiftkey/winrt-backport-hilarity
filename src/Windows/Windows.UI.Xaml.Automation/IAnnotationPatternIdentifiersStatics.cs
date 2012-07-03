using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[ExclusiveTo(typeof(AnnotationPatternIdentifiers)), Guid(3773014877u, 53607, 18140, 149, 171, 51, 10, 246, 26, 235, 181), Version(100794368u), WebHostHidden]
	internal interface IAnnotationPatternIdentifiersStatics
	{
		AutomationProperty AnnotationTypeIdProperty
		{
			get;
		}
		AutomationProperty AnnotationTypeNameProperty
		{
			get;
		}
		AutomationProperty AuthorProperty
		{
			get;
		}
		AutomationProperty DateTimeProperty
		{
			get;
		}
		AutomationProperty TargetProperty
		{
			get;
		}
	}
}
