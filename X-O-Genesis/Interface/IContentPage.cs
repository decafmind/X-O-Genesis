using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetvetPOS_Inventory_System
{
    /// <summary>
    /// Interface for add MyUserControl that appears in the mainPanel
    /// </summary>
    
    public interface IContentPage
    {
        // This method will be call from MenuControl when it has been selected.
        void initializePage();
        void finalizePage();
        Menu accessMenuName { get; }
        Bitmap accessImage { get; }
    }

}
