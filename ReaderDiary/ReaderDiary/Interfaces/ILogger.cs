namespace ReaderDiary.Interfaces
{
    /// <summary> Logger interface </summary>
    public interface ILogger
    {
        void Info(string tag, string text);

        void Error(string tag, string text);

        void Warning(string tag, string text);
    }
}
