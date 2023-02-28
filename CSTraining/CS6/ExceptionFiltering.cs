using System.Net.Sockets;
using static System.Net.HttpStatusCode;
namespace CS6
{

    public class ExceptionFiltering
    {
        public static async Task<string> Test(string url)
        {
            using var client = new HttpClient();
            try
            {
                return await client.GetStringAsync(url);
            }
            catch (HttpRequestException e) when (e.StatusCode == Moved)
            {
                return "Site moved";
            }
            catch (HttpRequestException e) when (e.StatusCode == NotFound)
            {
                return "Not found";
            }  
            catch(Exception e) when (e.Message.Contains("No such host is known"))
            {
                return "No such host is known";
            }
            catch (Exception ex)
            {
                return "Some other error";
            }
        }
    }
}