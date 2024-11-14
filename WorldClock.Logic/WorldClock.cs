﻿namespace WorldClock.Logic
{
    public sealed class WorldClock : Observable
    {
        #region fields
        private static readonly WorldClock _instance;
        #endregion fields

        static WorldClock()
        {
            _instance = new WorldClock();
            Start();
        }

        private WorldClock() { }

        public static WorldClock Instance
        {
            get
            {
                return _instance;
            }
        }

        private static void Start()
        {
            Thread thread = new Thread(Run);

            thread.IsBackground = true;
            thread.Start();
        }
        private static void Run()
        {
            while (true)
            {
                Thread.Sleep(1000);
                _instance.NotifyAll(new DateTimeArgs());
            }
        }
    }
}
