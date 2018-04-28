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

namespace OsuSkinnable
{
    /// <summary>
    /// Interaction logic for SkinElement.xaml
    /// </summary>
    public partial class SkinElement : UserControl
    {
        public string OutputName;

        public SkinElement(string name, string outputName, string imagePath = null)
        {
            InitializeComponent();

            OutputName = outputName;
            SkinElementName.Text = name;
            if (imagePath != null)
                SkinElementImage.Source = LoadBitmapImageFromPath(imagePath);
        }

        public BitmapImage LoadBitmapImageFromPath(string imagePath)
        {
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(imagePath, UriKind.Relative);
            bi.EndInit();

            return (bi);
        }
    }
}
