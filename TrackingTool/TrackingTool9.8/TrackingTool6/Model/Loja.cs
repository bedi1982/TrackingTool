using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrackingTool6.Model
{

    public class Loja
    {
        public int id { set; get; }
        public String nome { set; get; }
        public String CNPJ { set; get; }
        public String telefone { set; get; }
        public String rua { set; get; }
        public String bairro { set; get; }
        
        //codigo_hiperfarma dessa loja no cadastro da hiperfarma
        public int codigo_hiperfarma { set; get; }

        //Saldo por loja
        public float saldo { set; get; }

        //Esta abaixo é para a função de delete
        //true para ativo e 
        //false para inativo
        public Boolean status { set; get; }
    }
}