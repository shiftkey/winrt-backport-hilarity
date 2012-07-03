using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(RadioButton)), Guid(844907744u, 39427, 19443, 171, 214, 111, 187, 70, 201, 164, 134), Version(100794368u), WebHostHidden]
	internal interface IRadioButton
	{
		string GroupName
		{
			get;
			set;
		}
	}
}
