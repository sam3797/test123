namespace secondproject
{
    public static class secondprojectClass
    {

        public static void SayHello()
        {

             Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
       Trace.AutoFlush = true;
       Trace.Indent();
       Trace.WriteLine("Entering hello function");
       Console.WriteLine("Hello World.");
       Trace.WriteLine("Exiting hello function");
       Trace.Unindent();

        }
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
       Trace.AutoFlush = true;
       Trace.Indent();
       Trace.WriteLine("Entering Main");
       Console.WriteLine("Hello World.");
       Trace.WriteLine("Exiting Main...");
       Trace.Unindent();
        }


    }
}