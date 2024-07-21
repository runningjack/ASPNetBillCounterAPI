using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAppBillCounter.Models
{
    public class MenuItem
    {
        public string Icon { get; set; }
        public string Text { get; set; }
        public ICommand Command { get; set; }
    }

}
