#if NOESIS
using Noesis;
using NoesisApp;
#else
using System.Windows;
#endif

namespace Launcher
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
#if NOESIS
        protected override XamlProvider GetXamlProvider()
        {
            return new LocalXamlProvider();
        }
#endif
    }
}
