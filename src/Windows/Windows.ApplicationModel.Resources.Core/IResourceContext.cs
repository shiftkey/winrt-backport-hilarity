using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources.Core
{
	[ExclusiveTo(typeof(ResourceContext)), Guid(799158091u, 28798, 19239, 173, 13, 208, 216, 205, 70, 143, 210), Version(100794368u)]
	internal interface IResourceContext
	{
		IVectorView<string> Languages
		{
			get;
			set;
		}
		IObservableMap<string, string> QualifierValues
		{
			get;
		}
		[Overload("Reset")]
		void Reset();
		[Overload("ResetQualifierValues")]
		void Reset([In] IIterable<string> qualifierNames);
		void OverrideToMatch([In] IIterable<ResourceQualifier> result);
		ResourceContext Clone();
	}
}
