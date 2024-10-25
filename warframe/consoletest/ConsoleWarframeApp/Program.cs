// See https://aka.ms/new-console-template for more information


static async Task TestAsync<T>(string queryName)
{


    HttpClient httpClient = new();
    string requeststring = $"https://api.warframestat.us/pc/zh/{queryName}/";
    try
    {
        //Send the GET request
        var response = await httpClient.GetAsync(requeststring);
        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();
        var result = System.Text.Json.JsonSerializer.Deserialize<T>(json);

        System.Console.WriteLine(result?.ToString());
    }
    catch (Exception ex)
    {
        System.Console.WriteLine("Error: " + ex.HResult.ToString("X") + " Message: " + ex.Message);
    }






}



//await TestAsync<ArchonHunt>("archonHunt");
//await TestAsync<List<Alerts>>("alerts");
//await TestAsync<List<News>>("news");
//await TestAsync<CetusCycle>("cetusCycle");
await TestAsync<List<DailyDeals>>(DailyDeals.clientString);
//await TestAsync<Nightwave>(Nightwave.clientString);




Console.WriteLine("Hello, World!");
