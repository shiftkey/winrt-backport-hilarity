using System;
namespace Windows.Foundation.Metadata
{
	[Flags, Version(100794368u)]
	public enum AttributeTargets : uint
	{
		All = 4294967295u,
		Delegate = 1u,
		Enum = 2u,
		Event = 4u,
		Field = 8u,
		Interface = 16u,
		Method = 64u,
		Parameter = 128u,
		Property = 256u,
		RuntimeClass = 512u,
		Struct = 1024u,
		InterfaceImpl = 2048u
	}
}
