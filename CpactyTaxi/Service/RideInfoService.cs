using CpactyTaxi.Interfaces;
using CpactyTaxi.View_Models;
using Microsoft.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace CpactyTaxi.Service
{
    public class RideInfoService: IRideInfoRepository
    {
        private readonly IHttpClientFactory httpClientFactory;

        public RideInfoService(IHttpClientFactory _httpClientFactory)
        {
            httpClientFactory = _httpClientFactory;
        }

        public async Task<string> AccessToken()
        {
            HttpClient client = httpClientFactory.CreateClient();
            string clientId = "ecfAqnoCJjl2GSEYHjBuf8vbVTx4LEOf";
            string clientSecret = "b8JdF2Qw4tXZUItiF-F4xaU0GECNdxwA9Zph1580";

            var parametars = new Dictionary<string, string>
            {
                {"client_id",clientId },
                {"client_secret",clientSecret },
                {"grant_type","client_credentials" },
                {"scope","SPACE_DELIMITED_LIST_OF_SCOPES" },
            };
            var encodedContent= new FormUrlEncodedContent(parametars);
            var TokenResponse = new { client_id = clientId
                , client_secret = clientSecret
                , grant_type = "client_credentials",
                scope= "SPACE_DELIMITED_LIST_OF_SCOPES",
            };
            var TokenResponseJson = new StringContent(
       JsonSerializer.Serialize(TokenResponse),
       Encoding.UTF8,
       Application.Json);

            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/x-protobuf"));
            var result = await client.PostAsync("https://login.uber.com/oauth/v2/token", TokenResponseJson);
            return result.Content.ToString();
        }

        public async Task<TaxiResultDto> GetTaxiResult()
        { 

            var httpClient = httpClientFactory.CreateClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/x-protobuf"));
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "IA.VUNmGAAAAAAAEgASAAAABwAIAAwAAAAAAAAAEgAAAAAAAAGgAAAAFAAAAAAADgAQAAQAAAAIAAwAAAAOAAAAdAAAABwAAAAEAAAAEAAAADJ4t8Mjg7EhJOnCo");
            var httpResponseMessage = await httpClient.GetAsync("https://sandbox-api.uber.com/v1.2/estimates/price?start_latitude=37.7752315&start_longitude=-122.418075&end_latitude=37.7752415&end_longitude=-122.518075");
            TaxiResultDto taxiResultDto = new TaxiResultDto();
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                using var contentStream =
                    await httpResponseMessage.Content.ReadAsStreamAsync();

                taxiResultDto = await JsonSerializer.DeserializeAsync<TaxiResultDto>(contentStream);
                return taxiResultDto;
            }
            else
            {
                return null;
            }
        }
    }
}
