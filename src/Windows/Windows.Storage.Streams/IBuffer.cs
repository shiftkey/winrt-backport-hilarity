namespace Windows.Storage.Streams
{
	public interface IBuffer
	{
		uint Capacity { get; }
		uint Length { get; set; }
	}

    public class BufferAdapter : IBuffer
    {
        public BufferAdapter(byte[] bytes)
        {
            
        }

        public uint Capacity { get; private set; }
        public uint Length { get; set; }
    }

    public static class BufferExtensions
    {
        public static IBuffer AsBuffer(this byte[] bytes)
        {
            return new BufferAdapter(bytes);
        }
    }
}
