// See https://aka.ms/new-console-template for more information



await TestAsync<ArchonHunt>(ArchonHunt.clientString);
 await TestAsync<List<Alerts>>(Alerts.clientString);
 await TestAsync<List<News>>(News.clientString);
 await TestAsync<CetusCycle>(CetusCycle.clientString);

 await TestAsync<List<DailyDeals>>(DailyDeals.clientString);
 await TestAsync<Nightwave>(Nightwave.clientString);



 Console.ReadKey();
Console.WriteLine("Hello, World!");
return;

 
 
 
 
 
static async Task TestAsync<T>(string clientString)
{
    try
    {
        HttpClient httpClient = new();
        string requeststring = $"https://api.warframestat.us/pc/zh/{clientString}/";

        var response = await httpClient.GetAsync(requeststring);
        //response.EnsureSuccessStatusCode();
        var json = await response.Content.ReadAsStringAsync();
        var result = JsonSerializer.Deserialize<T>(json);

        Console.WriteLine(result?.ToString());

    }
    catch (Exception e)
    
    {
        Console.WriteLine(e.Message);
        throw;
    }

}
