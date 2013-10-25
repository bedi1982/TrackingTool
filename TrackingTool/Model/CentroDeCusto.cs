using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tracking.Model
{

    public class CentroDeCusto
    {
        public int id { set; get; }
        public String nome { set; get; }
        public String descricao { set; get; }
        public String codigo_hiperfarma { set; get; }
        public double saldo { set; get; }
        
        //true para ativo e 
        //0 para inativo
        public Boolean status { set; get; }
    }
}