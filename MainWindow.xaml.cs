namespace hpet
{
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            InitializeComponent();
            label1.Content = System.Diagnostics.Stopwatch.Frequency / System.Double.Parse("1000000") + "MHz";
        }
    }
}
