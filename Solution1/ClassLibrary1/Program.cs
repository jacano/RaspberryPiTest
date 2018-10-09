using Launcher;

namespace HelloTriangle.VideoCore
{
    class Program
    {
        static void Main()
        {
            var app = new App();
            app.Uri = "App.xaml";
            app.Run();
        }
    }
}
