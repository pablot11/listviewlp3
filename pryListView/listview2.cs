using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryListView
{
    public partial class listview2 : Form
    {
        public listview2()
        {
            InitializeComponent();
        }

        private void listview2_Load(object sender, EventArgs e)
        {
            string[] comidas = {
                "Pollo al horo", "fideos", "milanesas"
            };
            


            foreach (string comida in comidas)
            {
                ListViewItem lv = lv.Items.Add(comida); 


            }

        }
    }
}
