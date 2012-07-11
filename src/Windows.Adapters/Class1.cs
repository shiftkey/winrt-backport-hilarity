using System;
using System.Diagnostics;
using System.Text;

namespace Windows.Adapters
{
    // all these classes do not currently have good alternatives

    public static class Thread
    {
        public static void Sleep(int timeout)
        {
            
        }
    }

    public class Timer {  }

    public class StackTrace { }

    public class StackFrame { }

    public static class Console
    {
        private static StringBuilder sb = new StringBuilder();

        public static void WriteLine(string message)
        {
            
        }

        public static StringBuilder Error {get { return sb; }}
    }

}
