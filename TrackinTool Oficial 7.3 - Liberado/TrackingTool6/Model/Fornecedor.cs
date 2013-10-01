using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrackingTool6.Model
{

    public class Fornecedor
    {
        public int id { set; get; }
        public String nome { set; get; }
        public String CNPJ { set; get; }
        public String telefoneRes { set; get; }
        public String telefoneCel { set; get; }
        public String rua { set; get; }
        public String bairro { set; get; }
        public int numero { set; get; }

        //O valor é lançado no fornecedor e depois repassado para o centro de custo
        public float saldo { set; get; }
        
        public String complemento { set; get; }

        //O fornecedor tem uma lista de centros de custo para 
        //os quais ele já mandou dinheiro
        public virtual CentroDeCusto centrosde_custo{ set; get; }
        
        //1 para ativo e 0 para inativo - Podemor usar a função de deletar fornecedor aqui
        public Boolean status { set; get; }
    }
}