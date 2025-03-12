using Models;
using System.Net.Http.Json;

namespace Services
    {
    public class ViaCepService
        {
        private readonly HttpClient _httpClient;

        public ViaCepService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Endereco> ConsultaCepAsync(string cep)
            {
            try
                {
                var endereco = await _httpClient.GetFromJsonAsync<Endereco>($"https://viacep.com.br/ws/{cep}/json/");
                return endereco;
                }
            catch
                {
                return  null;
                }
            }
    }
    }
