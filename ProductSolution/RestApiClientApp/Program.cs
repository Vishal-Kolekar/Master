using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;
using System.Text;
using ProductCatlogAPI.UiManager;
using Staffing.Entity;


var client = new HttpClient();
client.BaseAddress = new Uri("http://localhost:5299/");

UiManager mgr = new UiManager();

try
{
    var response = await client.GetAsync("api/product");
    response.EnsureSuccessStatusCode();
    var content = await response.Content.ReadAsStringAsync();
    var products = JsonSerializer.Deserialize<List<Product>>(content);
    if (products != null)
    {
        mgr.ShowProduct(products);
        Console.WriteLine("Get Response : " + products);
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    client.Dispose();
}