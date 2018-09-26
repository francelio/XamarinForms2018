using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultarCep.Servico;
using App01_ConsultarCep.Servico.Modelo;

namespace App01_ConsultarCep
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BOTAO.Clicked += BuscarCep;
        }

        private void BuscarCep(object sender, EventArgs e)
        {
            //TODO - Logica do programa

            //TODO - Validações
            string cep = CEP.Text.Trim() ;

            if (isValidCep(cep))
            {
                try
                {
                    Endereco end = ViaCepServico.BuscarEnderecoViaCep(cep);
                    if (end != null)
                    {
                        RESULTADO.Text = string.Format("Endereço:{0}{1}-{2}", end.Logradouro, end.Localidade, end.Uf);
                    }
                    else
                    {
                        DisplayAlert("ERROR","O endereço não foi encontrado para o CEP informado:"+cep, "OK");
                    }

                }
                catch (Exception a)
                {
                    DisplayAlert("ERROR CRITICO", a.Message, "OK");
                  
                }
            }
            else
            {

            }
             
            // throw new NotImplementedException();
        }
        private bool isValidCep(string cep)
        {
            bool Valido = true;

            //if (cep.Length != 8)
            //{
            //    DisplayAlert("ERROR", "CEP Invalido! O CEP deve conter 8 caracteres", "OK");
            //    Valido= false;
            //}

            int NovoCep = 0;
            if (!int.TryParse(cep,out NovoCep))
            {
                DisplayAlert("ERROR", "CEP Invalido! O CEP deve ser composto por numeros", "OK");
                Valido = false;
            }

            return Valido;
        }
    }
}
