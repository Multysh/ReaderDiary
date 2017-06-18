namespace ReaderDiary
{
    using ReaderDiary.Interfaces;
    using Xamarin.Forms;

    public partial class App : Application
    {
        private readonly ILogger logger;

        public App(ILogger logger)
        {
            this.logger = logger;
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            logger.Info("MainApp", "OnStart");
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            logger.Info("MainApp", "OnSleep");
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            logger.Info("MainApp", "OnResume");
            // Handle when your app resumes
        }
    }
}
