using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    
    class diasemana
    {
        private DateTime data;

        public string receber
        {
            set
            {
                data = Convert.ToDateTime(value);
            }
        }

        public string envia
        {
            get
            {
                return data.ToString("ddddd");
            }
        }
    }
}
