using System;
using System.Collections.Generic;

public class SituacaoCadastral
{
    public string codigo { get; set; }
    public string data { get; set; }
    public string motivo { get; set; }

}
public class NaturezaJuridica
{
    public string codigo { get; set; }
    public string descricao { get; set; }
}

public class CnaePrincipal
{    public string codigo { get; set; }
    public string descricao { get; set; }
}

public class Municipio{
    public string codigo { get; set; }
    public string descricao { get; set; }
}

public class Pais{
    public string codigo { get; set; }
    public string descricao { get; set; }
}
public class Endereco
{
    public string tipoLogradouro { get; set; }
    public string logradouro { get; set; }
    public string numero { get; set; }
    public string complemento { get; set; }
    public string cep { get; set; }
    public string bairro { get; set; }
    public List<Municipio> Municipio { get; set; }
    public string uf { get; set; }
    public List<Pais> Pais { get; set; }
}

public class municipioJurisdicao
{
    public string codigo { get; set; }
    public string descricao { get; set; }
}


public class Telefones
{
    public string ddd { get; set; }
    public string numero { get; set; }
}



public class RepresentanteLegal
{
    public string cpf { get; set; }
    public string nome { get; set; }
    public string qualificacao { get; set; }
}

public class Socios
{
	public string tipoSocio  { get; set; }
	public string cpf { get; set; }
    public string nome { get; set; }
    public string qualificacao { get; set; }
    public string dataInclusao { get; set; }
    public List<Pais> Pais { get; set; }
    public string codigo { get; set; }
    public string descricao { get; set; }
    public List<RepresentanteLegal>RepresentanteLegal { get; set; }
}

public class RootObject
{
    public int ni { get; set; }
    public string tipoEstabelecimento { get; set; }
    public string nomeEmpresarial { get; set; }
    public string nomeFantasia { get; set; }
    public List<SituacaoCadastral> SituacaoCadastral { get; set; }    
    public List<NaturezaJuridica> NaturezaJuridica { get; set; }
    public string dataAbertura { get; set; }
    public List<CnaePrincipal> CnaePrincipal { get; set; }
    public List<Endereco> Endereco { get; set; }
    public List<municipioJurisdicao> MunicipioJurisdicao { get; set; }
    public List<Telefones> Telefones { get; set; }
    public string correioEletronico { get; set; }
    public string capitalSocial { get; set; }
    public string porte { get; set; }
    public string situacaoEspecial { get; set; }
    public string dataSituacaoEspecial { get; set; }
    public string informacoesAdicionais { get; set; }
    public List<Socios> Socios { get; set; }
}

