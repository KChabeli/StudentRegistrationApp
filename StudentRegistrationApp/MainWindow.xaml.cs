using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using StudentRegistrationApp.Models;
using System.Collections.ObjectModel;

namespace StudentRegistrationApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    // Public properties bound to the UI
    public Student StudentData { get; set; }
    public ObservableCollection<string> ModuleOptions { get; set; }

    public MainWindow()
    {
        InitializeComponent();

        // Create student instance and module options
        StudentData = new Student();
        ModuleOptions = new ObservableCollection<string>
            {
                "C# Programming", "Databases", "Java", "PHP"
            };

        // Set data context for binding
        DataContext = this;
    }

    // When submit button is clicked, generate the message
    private void Submit_Click(object sender, RoutedEventArgs e)
    {
        StudentData.Submit();
    }

    private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
    {

    }
}