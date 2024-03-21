using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.FontSize = 35;
            SetValue(counterKey, "hello");
        }
        //属性包装器，只提供GetValue
        public string Counter
        {
            get { return (string)GetValue(counterKey.DependencyProperty); }
        }

        //用RegisterReadOnly来代替Register来注册一个只读的依赖属性
        private static readonly DependencyPropertyKey counterKey =
            DependencyProperty.RegisterReadOnly("Counter",
                                                typeof(string),
                                                typeof(MainWindow),
                                                new PropertyMetadata("hello2"));

    }
}
