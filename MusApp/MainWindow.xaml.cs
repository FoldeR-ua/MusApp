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
using MusApp.Parsing;
using HtmlAgilityPack;
namespace MusApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        class Item
        {
            public string Number { get; set; }
            public string Title { get; set; }
            public string Artist { get; set; }
        }

        private void appearContent(object sender, EventArgs e)
        {
            ParsingMethod parsing = new ParsingMethod();
            var temp = parsing.ParsingNodes();
            var mus = temp.title;
            var artists = temp.artist;
            List<Item> items = new List<Item>();

            for (int i = 0; i < mus.Count; i++)
            {
                items.Add(new Item { Number = i+1 + ".", Title = mus[i].InnerText, Artist = artists[i].InnerText });
            }

            songList.ItemsSource = items;

        }
    }
}
