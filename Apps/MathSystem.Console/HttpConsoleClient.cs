using MathSystem.Domain.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace MathSystem.Console
{
  internal static class HttpConsoleClient
  {
    static HttpClient client = new HttpClient();

    static void ConfigureClient()
    {
      client.BaseAddress = new Uri("http://localhost:5002/");
      client.DefaultRequestHeaders.Accept.Clear();
      client.DefaultRequestHeaders.Accept.Add(
          new MediaTypeWithQualityHeaderValue("application/json"));
    }

    public static async Task<DivisorsModel> MakeDivision(int number)
    {
      ConfigureClient();

      HttpResponseMessage response = await client.PostAsJsonAsync("api/division", number);
      response.EnsureSuccessStatusCode();

      var result = await response.Content.ReadFromJsonAsync<DivisorsModel>();
      return result;
    }

  }
}
