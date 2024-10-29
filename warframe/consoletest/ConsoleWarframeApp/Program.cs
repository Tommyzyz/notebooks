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
    string language = "en";
    try
    {
        var socketsHttpHandler = new SocketsHttpHandler()
        {
           //建立TCP连接时的超时时间,默认不限制
           ConnectTimeout = Timeout.InfiniteTimeSpan,
           //等待服务返回statusCode=100的超时时间,默认1秒
           Expect100ContinueTimeout = TimeSpan.FromSeconds(100),
        };


        HttpClient httpClient = new(socketsHttpHandler);
        var requeststring = $"https://api.warframestat.us/pc/{language}/{GetGengricType<T>()}/";

        var response = await httpClient.GetAsync(requeststring);
        response.EnsureSuccessStatusCode();
        var json = await response.Content.ReadAsStringAsync();
        var result = JsonSerializer.Deserialize<T>(json);
        Console.WriteLine(result?.ToString());
        return result;
    }
    catch (Exception ex)
    {
        System.Console.WriteLine("Error: " + ex.HResult.ToString("X") + " Message: " + ex.Message);
        return default;//throw;
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