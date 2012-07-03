using System;
using Windows.Foundation.Metadata;
namespace Windows.Data.Xml.Dom
{
	[Version(100794368u)]
	public enum NodeType
	{
		Invalid,
		ElementNode,
		AttributeNode,
		TextNode,
		DataSectionNode,
		EntityReferenceNode,
		EntityNode,
		ProcessingInstructionNode,
		CommentNode,
		DocumentNode,
		DocumentTypeNode,
		DocumentFragmentNode,
		NotationNode
	}
}
