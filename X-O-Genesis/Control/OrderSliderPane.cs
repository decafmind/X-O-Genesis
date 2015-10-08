using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetvetPOS_Inventory_System
{
    public partial class OrderSliderPane : SliderPane, IKeyController
    {
        public OrderSliderPane()
        {
            InitializeComponent();
            max_width = (orders1.Width)/2 + orders1.Width;
        }

        private void OrderSliderPane_Load(object sender, EventArgs e)
        {
            orders1.accessMasterController = masterController;
            orders1.DatabaseController = masterController.DataBaseController;
        }

        public KeyFunction getKeyController
        {
            get { return orders1.getKeyController; }
        }
    }
}
