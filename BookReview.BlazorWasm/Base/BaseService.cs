using System.Net.Http.Json;
using CleanArchitecture.Domain.Entities;

namespace BookReview.BlazorWasm.Base;

public class BaseService
{
    
    private readonly HttpClient _httpClient;

    public BaseService(HttpClient client)
    {
        _httpClient = client;
    }



    public List<Employee> GetAllItems()
    {
        return GetAll();
    }


    private List<Employee> GetAll()
    {
        var response = _httpClient.GetAsync("Api/Employee");
        var result = response.Result.Content.ReadFromJsonAsync<List<Employee>>().Result;
        return result!;
    }
}