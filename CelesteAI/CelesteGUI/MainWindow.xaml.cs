using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using CelesteAI.CelesteData;

namespace CelesteAI.CelesteGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ChapterObject Chapter = new ChapterObject();

        public MainWindow()
        {
            InitializeComponent();

            Chapter.Chapter = Chapters.Prologue;
            this.DataContext = Chapter;
        }

        public void RunLevel(object sender, RoutedEventArgs e)
        {
            AIRuns.RunAI(Chapter.Chapter);
        }
    }
}
