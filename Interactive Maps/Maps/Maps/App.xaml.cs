namespace Maps
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
        protected override void OnStart()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;

            base.OnStart();

            // Add any platform-specific initialization here
            InitializeMaps();
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            // Log or handle the exception
            Console.WriteLine($"Unhandled exception: {e.ExceptionObject}");
        }

        private void TaskScheduler_UnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
        {
            // Log or handle the exception
            Console.WriteLine($"Unobserved task exception: {e.Exception}");
            e.SetObserved();
        }

        private void InitializeMaps()
        {
            // Check and request permissions if necessary
            // This is just an example, you may need to adjust it based on your requirements
            if (DeviceInfo.Platform == DevicePlatform.WinUI)
            {
                // Initialize maps for Windows platform
                // Add any platform-specific map initialization code here
            }
        }
    }
}