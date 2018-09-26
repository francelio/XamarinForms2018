using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App01_ConsultarCep.Servico.Modelo;
using Newtonsoft.Json;

namespace App01_ConsultarCep.Servico
{
    public class ViaCepServico
    {
        private static string EnderecoURL = "http://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCep(string cep) {
            string NovoEnderecoURL = string.Format(EnderecoURL, cep);

            WebClient wc = new WebClient();
            string Conteudo = wc.DownloadString(NovoEnderecoURL);
            
            //Deserializando 
            Endereco end = JsonConvert.DeserializeObject<Endereco>(Conteudo);
            if (end.Cep == null) return null;

            return end;
            
        }
    }
}
