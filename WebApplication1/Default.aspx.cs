using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI; //usado para o messagebox (alert sem javascript)
using System.Web.UI.WebControls;
using System.Text;
using System.Net.Http; //usado para o httpclient consumir a API
using Newtonsoft.Json; //usado para deserializar json
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Json;
using System.Net.Http.Headers;
using System.IO;
using System.Net; // usado para o TLS (HTTPS)
using System.Data;
using FastMember;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        List<Registro> listaRegistro = new List<Registro>();
        protected void Page_Load(object sender, EventArgs e){}

        protected void Button1_Click(object sender, EventArgs e)
        {
            ConsomeApiSerpro();
        }

       //------------
	   protected async void ConsomeApiSerpro()
        {
            var CNPJ = "34238864000168".ToString();

            var URL = "https://gateway.apiserpro.serpro.gov.br/consulta-cnpj-df-trial/v2/empresa/" + CNPJ;

            var BaseURL = new Uri(URL);
            

            HttpClient client = new HttpClient() { BaseAddress = BaseURL };
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            
            //headers necessários:
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Authorization", "Bearer 06aef429-a981-3ec5-a1f8-71d38d86481e");
            
                       {
                HttpResponseMessage response = await client.GetAsync(URL);

                if (response.IsSuccessStatusCode)
                {
                    var RetornoSERPRO1 = await response.Content.ReadAsStringAsync();

                    var RetornoSERPRO2 = JsonConvert.DeserializeObject(RetornoSERPRO1);

                     string sLine = RetornoSERPRO1; 
                    TextBox1.Text = RetornoSERPRO2.ToString();
                    dynamic jsonTratado = JsonValue.Parse(sLine);
                   
                    Registro registro = new Registro();
                    registro.codigo = codigo;
                    registro.nome = nome;
                    registro.motivo = motivo;
                    registro.data = data;
                    registro.qualificacao = qualificacao;
                    registro.tipoSocio = tipoSocio;
                    registro.cpf = cpf;
                    registro.nomeRep = nomeRep;
                    registro.qualificacaoRep = qualificacaoRep;
                    registro.dataInclusao = dataInclusao;
                    registro.cpfRep = cpfRep;
                    

                    listaRegistro.Add(registro);




                    DataTable dados = new DataTable();
                    
                    using (var reader = ObjectReader.Create(listaRegistro))
                    {
                        dados.Load(reader);
                    }
                   

                    
                    dgvDados.DataSource = dados;
                    dgvDados.DataBind();

                }
                else
                {
                    //TextBox1.Text = response.StatusCode.ToString();
                    ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('Retorno API: "+response.StatusCode.ToString()+"')", true);
                }
            }


    }
		//---------------
    }


    
}
