namespace WorldClock.ConApp
{
    internal class BadObserver : Logic.IObserver
    {
        public void Update(object sender, EventArgs e)
        {
            Thread.Sleep(5000);
        }
    }
}
