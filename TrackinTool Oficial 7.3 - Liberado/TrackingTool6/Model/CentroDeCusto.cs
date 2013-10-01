using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrackingTool6.Model
{

    public class CentroDeCusto
    {
        public int id { set; get; }
        public String nome { set; get; }
        public String CNPJ { set; get; }
        public String telefone { set; get; }
        public String rua { set; get; }
        public String bairro { set; get; }
        public int numero { set; get; }
        public float saldo { set; get; }
        //1 para ativo e 0 para inativo
        //public Boolean status { set; get; }
    }
}