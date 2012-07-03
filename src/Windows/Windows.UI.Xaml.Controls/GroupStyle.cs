using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Data;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(IGroupStyleFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class GroupStyle : IGroupStyle, INotifyPropertyChanged
	{
		public extern event PropertyChangedEventHandler PropertyChanged
		{
			add;
			remove;
		}
		public extern Style ContainerStyle
		{
			get;
			set;
		}
		public extern StyleSelector ContainerStyleSelector
		{
			get;
			set;
		}
		public extern DataTemplate HeaderTemplate
		{
			get;
			set;
		}
		public extern DataTemplateSelector HeaderTemplateSelector
		{
			get;
			set;
		}
		public extern bool HidesIfEmpty
		{
			get;
			set;
		}
		public extern ItemsPanelTemplate Panel
		{
			get;
			set;
		}
		public extern GroupStyle();
	}
}
