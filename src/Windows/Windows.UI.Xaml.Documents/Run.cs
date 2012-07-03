using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
namespace Windows.UI.Xaml.Documents
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IRunStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Text")]
	public sealed class Run : Inline, IRun
	{
		public extern FlowDirection FlowDirection
		{
			get;
			set;
		}
		public extern string Text
		{
			get;
			set;
		}
		public static extern DependencyProperty FlowDirectionProperty
		{
			get;
		}
		public extern Run();
	}
}
