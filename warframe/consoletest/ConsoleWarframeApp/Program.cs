// See https://aka.ms/new-console-template for more information



 await TestAsync<archonHunt>();
  await TestAsync<List<alerts>>();
  await TestAsync<List<news>>();
  await TestAsync<cetusCycle>();

  await TestAsync<List<dailyDeals>>();
 var rs =  await TestAsync<nightwave>();


Console.WriteLine(rs);
return;


 
static async Task<T> TestAsync<T>()
{
    try
    {
        HttpClient httpClient = new();
        var requeststring = $"https://api.warframestat.us/pc/zh/{GetGengricType<T>()}/";

        var response = await httpClient.GetAsync(requeststring);
        //response.EnsureSuccessStatusCode();
        var json = await response.Content.ReadAsStringAsync();
        var result = JsonSerializer.Deserialize<T>(json);
        Console.WriteLine(result?.ToString());
        return result;
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        throw;
    }
}


static string GetGengricType<T>()
{
    Type type = typeof(T);
    if (type.IsGenericType)
    {
        type = type.GetGenericArguments()[0];
    }
    return type.Name;
}