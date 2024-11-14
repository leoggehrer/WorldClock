namespace WorldClock.ConApp
{
    internal class ConsoleClock : Logic.IObserver
    {
        private static readonly object lockObject = new object();
        private int _offset = 0;
        private string _text;
        private ConsoleColor _foregroundColor = ConsoleColor.Green;

        public ConsoleClock(int offset, string text, ConsoleColor forgroundColor)
        {
            _offset = offset;
            _text = text;
            _foregroundColor = forgroundColor;
        }
        public void Update(object sender, EventArgs e)
        {
            lock(lockObject)
            {
                if (e is Logic.DateTimeArgs args)
                {
                    ConsoleColor saveColor = Console.ForegroundColor;

                    Console.ForegroundColor = _foregroundColor;

                    Console.WriteLine($"{_text + ":", -10} {args.Time.AddHours(_offset)}");

                    Console.ForegroundColor = saveColor;
                }
            }
        }
    }
}
