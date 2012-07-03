using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(Style)), Guid(3299471909u, 40375, 19069, 182, 209, 247, 78, 219, 146, 147, 194), Version(100794368u), WebHostHidden]
	internal interface IStyle
	{
		Style BasedOn
		{
			get;
			set;
		}
		bool IsSealed
		{
			get;
		}
		SetterBaseCollection Setters
		{
			get;
		}
		TypeName TargetType
		{
			get;
			set;
		}
		void Seal();
	}
}
