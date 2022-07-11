using System;
using System.Diagnostics;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string IterationCount = "100000";
            var generator = new FizzBuzzGenerator();
            //var stopWatch = new Stopwatch();

            //stopWatch.Start();
            //var first = generator.GetSequence("1", IterationCount);
            //stopWatch.Stop();


            //var parsingElapsed = stopWatch.Elapsed;
            //Console.WriteLine(parsingElapsed.Ticks);

            //var newstopWatch = new Stopwatch();
            //newstopWatch.Start();
            //var second = generator.GetSequenceWithParsing("1", IterationCount);
            //newstopWatch.Stop();

            //var originalSequenceElapsed = newstopWatch.Elapsed;
            //Console.WriteLine(originalSequenceElapsed.Ticks);

            var listStopwatch = new Stopwatch();
            listStopwatch.Start();
            var third = generator.GetSequenceWithParsingAndWithList("1", IterationCount);
            listStopwatch.Stop();

            var listElapsed = listStopwatch.Elapsed;
            Console.WriteLine(listElapsed.Ticks);

            var sbStopwatch = new Stopwatch();
            sbStopwatch.Start();
            var fourth = generator.GetSequenceWithParsingAndWithStringBuilder("1", IterationCount);
            sbStopwatch.Stop();

            var sbElapsed = sbStopwatch.Elapsed;
            Console.WriteLine(sbElapsed.TotalMilliseconds);

            var capacitysbStopwatch = new Stopwatch();
            capacitysbStopwatch.Start();
            var fifth = generator.GetSequenceWithParsingAndWithPrealocatedStringBuilder("1", IterationCount, 1_000_000);
            capacitysbStopwatch.Stop();

            var capacitysbElapsed = capacitysbStopwatch.Elapsed;
            Console.WriteLine(capacitysbElapsed.TotalMilliseconds);

            var capacity = fifth.Length;
            Console.WriteLine(capacity);

            Console.ReadLine();
        }
    }
}
