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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<string, SkinElementViewer> _SkinElementViewers;

        public MainWindow()
        {
            InitializeComponent();

            _SkinElementViewers = new Dictionary<string, SkinElementViewer>()
            {
                { "SkinStandardElementViewer", new SkinElementViewer(new List<SkinElement>()
                    {

                    })
                },
                { "SkinTaikoElementViewer", new SkinElementViewer(new List<SkinElement>()
                    {

                    })
                },
                { "SkinCtBElementViewer", new SkinElementViewer(new List<SkinElement>()
                    {

                    })
                },
                { "SkinManiaElementViewer", new SkinElementViewer(new List<SkinElement>()
                    {

                    })
                },
                { "SkinInterfaceElementViewer", new SkinElementViewer(new List<SkinElement>()
                    {
                        new SkinElement("Menu background", "menu-background.jpg"),
                        new SkinElement("Welcome text", "welcome_text.png"),
                        new SkinElement("Snow sprite", "menu-snow.png"),
                        new SkinElement("Options offset tick", "options-offset-tick.png"),
                        new SkinElement("Cursor", "cursor.png"),
                        new SkinElement("Cursortrail", "cursortrail.png"),
                        new SkinElement("Cursor middle", "cursormiddle.png"),
                        new SkinElement("Cursor smoke", "cursor-smoke.png"),
                        new SkinElement("Menu button background", "menu-button-background.png"),
                        new SkinElement("Star unfilled", "star.png"),
                        new SkinElement("Star filled", "star2.png"),
                        new SkinElement("Selection mode", "selection-mode.png"),
                        new SkinElement("Selection mode over", "selection-mode-over.png"),
                        new SkinElement("Selection mod", "selection-mods.png"),
                        new SkinElement("Selection mod over", "selection-mods-over.png"),
                        new SkinElement("Selection random", "selection-random.png"),
                        new SkinElement("Selection random over", "selection-random-over.png"),
                        new SkinElement("Selection options", "selection-options.png"),
                        new SkinElement("Selection options over", "selection-options-over.png"),
                        new SkinElement("Selection tab", "selection-tab.png"),
                    })
                },
                { "SkinSoundElementViewer", new SkinElementViewer(new List<SkinElement>()
                    {

                    })
                }
            };

            SkinStandardElementViewer.Content = _SkinElementViewers["SkinStandardElementViewer"];
            SkinTaikoElementViewer.Content = _SkinElementViewers["SkinTaikoElementViewer"];
            SkinCtBElementViewer.Content = _SkinElementViewers["SkinCtBElementViewer"];
            SkinManiaElementViewer.Content = _SkinElementViewers["SkinManiaElementViewer"];
            SkinInterfaceElementViewer.Content = _SkinElementViewers["SkinInterfaceElementViewer"];
            SkinSoundElementViewer.Content = _SkinElementViewers["SkinSoundElementViewer"];
        }
    }
}
