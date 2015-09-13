using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class ContentArgs: EventArgs
    {
        public IContentPage currentContent { get; private set; }
        public ContentArgs(IContentPage content)
        {
            this.currentContent = content;
        }
    }
}
