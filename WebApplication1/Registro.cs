using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Registro
    {
        public int ni { get; set; }
        public string tipoEstabelecimento { get; set; }
        public string nomeEmpresarial { get; set; }
        public string nomeFantasia { get; set; }
        public string Nome { get; set; }

        //informação situação cadastral
        public string motivo { get; set; }
        public string codigo { get; set; }
        public string data { get; set; }

        //informações quadro societário

        public List<socios> socios { get; set; }
        public string tipoSocio { get; set; }
        public string cpf { get; set; }
        public string nome { get; set; }
        public string qualificacao { get; set; }
        public string dataInclusao { get; set; }

        //informação representante legal
        public string cpfRep { get; set; }
        public string nomeRep { get; set; }
        public string qualificacaoRep { get; set; }
        
    }
}

public class socios
{
    public string tipoSocio { get; set; }
    public string cpf { get; set; }
    public string nome { get; set; }
    public string qualificacao { get; set; }
    public string dataInclusao { get; set; }
    //public List<pais> Pais { get; set; }
    public string codigo { get; set; }
    public string descricao { get; set; }
    public List<representanteLegal> RepresentanteLegal { get; set; }
}

public class representanteLegal
{
    public string cpf { get; set; }
    public string nome { get; set; }
    public string qualificacao { get; set; }
}
