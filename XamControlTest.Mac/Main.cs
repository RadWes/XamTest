using AppKit;

namespace XamControlTest.Mac
{
    static class MainClass
    {
        static void Main(string[] args)
        {
            NSApplication.Init();
            NSApplication.SharedApplication.Delegate = new AppDelegate(); // add this line
            NSApplication.Main(args); //<< Xamarin.Forms MacOS: Cannot access a disposed object. Object name: 'FormsNSTextField'
        }
    }
}
