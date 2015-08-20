using SplitviewUWP.Models;
using Windows.Foundation;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Controls;

namespace SplitviewUWP
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(340, 530));
        }

        private void Menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var list = (ListBox)sender;
            if (list.SelectedIndex == -1)
                return;
            var contentFrame = ContentFrame as Frame;
            contentFrame.Navigate(((MenuItem)list.SelectedItem).View);
            if(NavigationSplitView.DisplayMode == SplitViewDisplayMode.CompactOverlay || NavigationSplitView.DisplayMode == SplitViewDisplayMode.Overlay)
                NavigationSplitView.IsPaneOpen = false;
        }

        private void MenuButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            NavigationSplitView.IsPaneOpen = !NavigationSplitView.IsPaneOpen;
        }
    }
}