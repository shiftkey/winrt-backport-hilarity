using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(SetterBaseCollection)), Guid(63179944u, 37022, 16663, 129, 28, 164, 82, 148, 150, 189, 241), Version(100794368u), WebHostHidden]
	internal interface ISetterBaseCollection : IVector<SetterBase>, IIterable<SetterBase>
	{
		bool IsSealed
		{
			get;
		}
	}
}
