using System;
using System.Threading;
using System.Threading.Tasks;
namespace Windows.Foundation
{
	public interface IAsyncOperation<TResult> : IAsyncInfo
	{
		AsyncOperationCompletedHandler<TResult> Completed { get; set; }
		TResult GetResults();
	}

    public class AsyncOperationShim<TResult> : IAsyncOperation<TResult>
    {
        Task<TResult> task;
        CancellationToken token;

        public AsyncOperationShim(Task<TResult> task)
        {
            this.task = task;
        }

        public AsyncOperationShim(Func<TResult> action, CancellationToken token)
        {
            this.task = new Task<TResult>(action, token);
            this.token = token;
        }

        public AsyncOperationCompletedHandler<TResult> Completed { get; set; }

        public TResult GetResults()
        {
            task.Wait();
            return task.Result;
        }

        public HResult ErrorCode
        {
            get; private set; // TODO: what on earth shall i put here?
        }

        public uint Id
        {
            get { return (uint)task.Id; }
        }

        public AsyncStatus Status
        {
            get
            {
                if (task.Status == TaskStatus.Canceled) return AsyncStatus.Canceled;
                if (task.Status == TaskStatus.Faulted) return AsyncStatus.Error;
                if (task.Status == TaskStatus.RanToCompletion) return AsyncStatus.Completed;
                return AsyncStatus.Started;
            }
        }

        public void Cancel()
        {
            // TODO
        }

        public void Close()
        {
            // TODO
        }
    }
}
