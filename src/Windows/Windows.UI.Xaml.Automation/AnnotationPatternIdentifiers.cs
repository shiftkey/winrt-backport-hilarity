using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IAnnotationPatternIdentifiersStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class AnnotationPatternIdentifiers : IAnnotationPatternIdentifiers
	{
		public static extern AutomationProperty AnnotationTypeIdProperty
		{
			get;
		}
		public static extern AutomationProperty AnnotationTypeNameProperty
		{
			get;
		}
		public static extern AutomationProperty AuthorProperty
		{
			get;
		}
		public static extern AutomationProperty DateTimeProperty
		{
			get;
		}
		public static extern AutomationProperty TargetProperty
		{
			get;
		}
	}
}
