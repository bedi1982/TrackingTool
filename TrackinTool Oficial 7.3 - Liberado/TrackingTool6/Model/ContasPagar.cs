using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrackingTool6.Model
{
    public class ContasPagar
    {
        public int id { set; get; }
        public string doc { set; get; }
        public virtual DateTime emissao { set; get; }
        public virtual DateTime vencimento { set; get; }
        public float valor { set; get; }
        public virtual Fornecedor forn { set; get; }
        public string despesa { set; get; }
        public virtual CentroDeCusto centrosde_Custo { set; get; }
        public virtual DateTime dataPagto { set; get; }
        public string bancoConta { set; get; }
        public int cheque { set; get; }
        public float juros { set; get; }
        public float desconto { set; get;}
        public float valorPago { set; get; }
        public string observacao { set; get; }

    }
}
