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
                DateTime hoje = DateTime.Now;
                int anos = hoje.Year - data.Year;
                int meses = hoje.Month - data.Month;
                int dias = hoje.Day - data.Day;
                if (meses < 0)
                {
                    anos--;
                    dias += 30;
                }
                string frase = "A sua idade é ";
                frase += anos.ToString() + " anos e ";
                frase += meses.ToString() + " meses e ";
                frase += dias.ToString() + " dias.";

                return frase;
            }
        }
    }
}
