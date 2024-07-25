using Avalonia.Controls;
using Avalonia.Threading;

namespace XYFocusSearchIssue.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    private void Button_AttachedToVisualTree(object? sender, Avalonia.VisualTreeAttachmentEventArgs e)
    {
        if(sender is Button button) { 
            Dispatcher.UIThread.Post(() => { button.Focus(Avalonia.Input.NavigationMethod.Tab); }, DispatcherPriority.Background);
        }
    }
}
