using System;
using System.Collections.Generic;
using System.Text;

namespace Section2Excercises
{
    public class Stopwatch
    {
        public DateTime InitialTime { get; private set; }
        public DateTime FinalTime { get; private set; }
        public bool IsWorking { get; private set; }
        //public TimeSpan Duration { get; private set; }

        public Stopwatch()
        {
            this.IsWorking = false;
        }

        public void Start(DateTime startTime)
        {
            if (!IsWorking)
            {
                this.InitialTime = startTime;
                this.IsWorking = true;
                Console.WriteLine("Stopwatch started working at: " + InitialTime);
            }
            else
            {
                throw new InvalidOperationException("Cannot start the stopwatch twice");
            }
        }

        public TimeSpan Stop(DateTime stopTime)
        {
            try
            {
                if (IsWorking)
                {
                    FinalTime = stopTime;
                    IsWorking = false;
                    Console.WriteLine("Stopwatch stop working at: " + FinalTime);
                }
                else
                {
                    throw new InvalidOperationException("The device hasn't started");
                }

                return FinalTime - InitialTime;
            }
            finally
            {
                InitialTime = new DateTime();
                FinalTime = new DateTime();
            }
        }
    }
}
