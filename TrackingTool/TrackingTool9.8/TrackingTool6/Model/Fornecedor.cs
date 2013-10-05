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
        public String rua { set; get; }
        public String bairro { set; get; }
        public int numero_endereco { set; get; }
        public int codigo_hiperfarma { set; get; }

                
        public String complemento { set; get; }

        //Abaixo//
        //true para ativo e 
        //false para inativo - 
        //Podemor usar a função de deletar fornecedor aqui
        public Boolean status { set; get; }
    }
}