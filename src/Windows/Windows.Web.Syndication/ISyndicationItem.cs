using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[ExclusiveTo(typeof(SyndicationItem)), Guid(1418573955u, 50052, 17857, 138, 232, 163, 120, 196, 236, 72, 108), Version(100794368u)]
	internal interface ISyndicationItem : ISyndicationNode
	{
		IVector<SyndicationPerson> Authors
		{
			get;
		}
		IVector<SyndicationCategory> Categories
		{
			get;
		}
		Uri CommentsUri
		{
			get;
			set;
		}
		SyndicationContent Content
		{
			get;
			set;
		}
		IVector<SyndicationPerson> Contributors
		{
			get;
		}
		string ETag
		{
			get;
		}
		Uri EditMediaUri
		{
			get;
		}
		Uri EditUri
		{
			get;
		}
		string Id
		{
			get;
			set;
		}
		Uri ItemUri
		{
			get;
		}
		DateTime LastUpdatedTime
		{
			get;
			set;
		}
		IVector<SyndicationLink> Links
		{
			get;
		}
		DateTime PublishedDate
		{
			get;
			set;
		}
		ISyndicationText Rights
		{
			get;
			set;
		}
		SyndicationFeed Source
		{
			get;
			set;
		}
		ISyndicationText Summary
		{
			get;
			set;
		}
		ISyndicationText Title
		{
			get;
			set;
		}
		void Load([In] string item);
		void LoadFromXml([In] XmlDocument itemDocument);
	}
}
