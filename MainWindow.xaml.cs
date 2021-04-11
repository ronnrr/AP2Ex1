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
using Microsoft.Win32;
using System.Windows;
using System.IO;
using System.Xml;



namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = new ViewModel(new APEx1.Model());
            DataContext = vm;
            LoadList();
        }
        
        public void PlayClick(object sender, RoutedEventArgs e)
        {
            vm.playAnimation();
        }
        public void PauseClick(object sender, RoutedEventArgs e)
        {
            vm.pauseAnimation();
        }
        public void StopClick(object sender, RoutedEventArgs e)
        {
            vm.stopAnimation();
        }
        public void IncreaseFrequency(object sender, RoutedEventArgs e)
        {
            int currFrequency = vm.VM_Frequency;
            vm.playAnimationFrequency(currFrequency / 2);
        }
        public void DecreaseFrequency(object sender, RoutedEventArgs e)
        {
            int currFrequency = vm.VM_Frequency;
            vm.playAnimationFrequency(currFrequency * 2);
        }
        public void OpenFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            File.ReadAllText(openFileDialog.FileName);
            string a = openFileDialog.FileName;
            vm.setModelFileName(a);
        }
        public void ValueChanged(object sender, RoutedEventArgs e)
        {
            Slider slider = sender as Slider;
            vm.updateCurrentLine((int)slider.Value);
        }

        public void LoadList() 
        {
            string name = "C://playback_small.xml";
            XmlDocument doc = new XmlDocument();  
            doc.Load(name);
            XmlNodeList input = doc.SelectNodes("//PropertyList/generic/input/chunk");
            foreach (XmlNode node in input) 
            {
                ListBoxItem newItem = new ListBoxItem();
                newItem.Content = node["name"].InnerText;
                this.list.Items.Add(newItem);
            }
        
        }
    }
}
/* MAKE SURE THE PROGRESS BAR KEEPS UP WITH THE VIDEO ITSELF */

