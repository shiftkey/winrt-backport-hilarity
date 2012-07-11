using System;
using System.Reflection;

namespace Windows.Adapters
{
    // all these classes do not currently have good alternatives
    // and are simply there for me to get code compiling

    public class Thread {
        public static Thread CurrentThread { get; private set; }
        public static void Sleep(int timeout) {
            
        }

        public int ManagedThreadId { get; private set; }
    }

    public class Timer : IDisposable {
        public Timer(Action<object> autoClosingTimerCallback, object o, TimeSpan i, TimeSpan i1)
        {
            throw new NotImplementedException();
        }

        public Timer(Action<object> autoClosingTimerCallback, object o, int i, int i1)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Change(int infinite, int i)
        {
            
        }
    }

    public class StackTrace {
        public StackFrame GetFrame(int someNumber) {
            return new StackFrame(someNumber);
        }

        public int FrameCount
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class StackFrame {
        public StackFrame(int i)
        {
            throw new NotImplementedException();
        }

        public MethodBase GetMethod() {
            return null;
        }
    }

    public static class Console {
        static readonly ErrorLogger errorLogger = new ErrorLogger();

        public static void WriteLine(string message) {
            
        }

        public static ErrorLogger Error { get { return errorLogger; } }
    }

    public class ErrorLogger {
        public void WriteLine(string msg) {

        }
    }

    public static class ThreadPool {
        public static void QueueUserWorkItem(Action<object> action)
        {
            
        }
    }
}