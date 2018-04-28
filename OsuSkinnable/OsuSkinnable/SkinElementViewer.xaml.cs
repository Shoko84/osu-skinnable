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
    /// Interaction logic for SkinElementViewer.xaml
    /// </summary>
    public partial class SkinElementViewer : UserControl
    {
        private List<SkinElement> _SkinElements;

        public SkinElementViewer(List<SkinElement> skinElements = null)
        {
            InitializeComponent();

            _SkinElements = skinElements ?? new List<SkinElement>();
            RefreshSkinElementViewer();
        }

        public void RefreshSkinElementViewer()
        {
            SkinElementContainer.Children.Clear();

            for (var i = 0; i < _SkinElements.Count; ++i)
                SkinElementContainer.Children.Add(_SkinElements[i]);
        }

        public void AddSkinElement(SkinElement skinElement)
        {
            _SkinElements.Add(skinElement);
            RefreshSkinElementViewer();
        }
    }
}
