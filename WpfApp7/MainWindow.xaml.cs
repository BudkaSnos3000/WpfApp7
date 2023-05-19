using System.Windows;

// Одно пространство имён.
namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}

// Другое пространство имён. 
// Назвать можете как вам удобно. Повторять за мной не обязательно.
namespace AttachedProperties
{
   public static class Helper
    {
            public static Style GetAdditionalStyle(DependencyObject dObj)
            {
                return (Style)dObj.GetValue(AdditionalStyleProperty);
            }

            public static void SetPlaceholderStyle(DependencyObject dObj, Style value)
            {
                dObj.SetValue(AdditionalStyleProperty, value);
            }

            // Using a DependencyProperty as the backing store for PlaceholderStyle.  This enables animation, styling, binding, etc...
            public static readonly DependencyProperty AdditionalStyleProperty =
                DependencyProperty.RegisterAttached(nameof(GetAdditionalStyle)[3..], typeof(Style), typeof(Helper), new PropertyMetadata(null));
        }
   
}