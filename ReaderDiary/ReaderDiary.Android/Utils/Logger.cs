namespace ReaderDiary.Droid.Utils
{
    using ReaderDiary.Interfaces;

    internal class Logger : ILogger
    {
        public void Info(string tag, string text)
        {
            Android.Util.Log.Info(tag, text);
        }

        public void Error(string tag, string text)
        {
            Android.Util.Log.Error(tag, text);
        }

        public void Warning(string tag, string text)
        {
            Android.Util.Log.Warn(tag, text);
        }
    }
}