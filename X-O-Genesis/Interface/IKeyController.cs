using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    /// <summary>
    /// Delegate used to dynamically changed the keybindings
    /// </summary>
    /// <param name="e"></param>
    public delegate void KeyFunction(System.Windows.Forms.KeyEventArgs e);

    /// <summary>
    /// Implemented by userController that has keybinding
    /// </summary>
    
    public interface IKeyController
    {
        KeyFunction getKeyController { get;  }
    }
}
