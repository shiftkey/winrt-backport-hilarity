using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(GroupStyle)), Guid(1909075979u, 47262, 16772, 176, 223, 169, 233, 84, 71, 222, 141), Version(100794368u), WebHostHidden]
	internal interface IGroupStyle
	{
		Style ContainerStyle
		{
			get;
			set;
		}
		StyleSelector ContainerStyleSelector
		{
			get;
			set;
		}
		DataTemplate HeaderTemplate
		{
			get;
			set;
		}
		DataTemplateSelector HeaderTemplateSelector
		{
			get;
			set;
		}
		bool HidesIfEmpty
		{
			get;
			set;
		}
		ItemsPanelTemplate Panel
		{
			get;
			set;
		}
	}
}
