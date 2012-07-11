using System;

namespace Windows.Adapters
{
    // all these classes do not currently have good alternatives
    // and are simply there for me to get code compiling

    public static class Thread {
        public static void Sleep(int timeout) {
            
        }
    }

    public class Timer {  }

    public class StackTrace {
        public StackFrame GetFrame(int someNumber) {
            return new StackFrame();
        }
    }

    public class StackFrame { }

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
}