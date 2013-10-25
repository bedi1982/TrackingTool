using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tracking.Model
{
    class ContaAPagar
    {
        public int id { set; get; }
        public double valor { set; get; }
        //dataRecebe será a data em que a conta deverá ser recebida;
        public DateTime dataRecebe { set; get; }
        //dataCadastrado será a data e a hora em que a conta foi cadastrada no sistema;
        public DateTime dataCadastrado { set; get; }
        public String descricao { set; get; }
        public String centroCusto { set; get; }
        public String codigo { set; get; }
        public String fornecedor { set; get; }
        public String loja { set; get; }
        public String tipo { set; get; }

        //false para conta não paga e 
        //true para conta paga - 
        //Sempre é inicializada como não recebida//
        public Boolean status { set; get; }
    }
}