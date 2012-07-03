using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[ExclusiveTo(typeof(SyndicationPerson)), Guid(3707013229u, 8861, 19288, 164, 155, 243, 210, 240, 245, 201, 159), Version(100794368u)]
	internal interface ISyndicationPersonFactory
	{
		[Overload("CreateSyndicationPerson")]
		SyndicationPerson CreateSyndicationPerson([In] string name);
		[Overload("CreateSyndicationPersonEx")]
		SyndicationPerson CreateSyndicationPerson([In] string name, [In] string email, [In] Uri uri);
	}
}
