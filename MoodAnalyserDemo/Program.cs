namespace MoodAnalyserDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, This is Mood Analyser");
            string msg = "i am happy";
            string msg1 = "i am ok";
            MoodAnalyser obj = new MoodAnalyser(msg);
            Console.WriteLine($"mood for message {msg} is {obj.analyseMood()}");
            //Console.WriteLine($"mood for message {msg1} is {obj.analyseMood(msg1)}");
        }
    }
}