using Kitchen.Modules;
using KitchenLib.Preferences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KitchenDutchSnacks
{
    public class DutchSnacksMenu<T> : KLMenu<T>
    {
        public DutchSnacksMenu(Transform container, ModuleList moduleList) : base(container, moduleList)
        {

        }

        public override void Setup(int player_id)
        {
        }
    }
}
