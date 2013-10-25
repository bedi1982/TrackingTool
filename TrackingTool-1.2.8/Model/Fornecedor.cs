using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tracking.Model
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
        public String codigo_hiperfarma { set; get; }
        public String email { set; get; }
        public String complemento { set; get; }
        public String UF { set; get; }
        public String cidade { set; get; }


        //Abaixo//
        //true para ativo e 
        //false para inativo - 
        //Podemor usar a função de deletar fornecedor aqui
        public Boolean status { set; get; }
    }
}