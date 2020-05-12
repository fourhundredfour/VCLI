using System;
using System.Net.Http;
using System.Text;

namespace VCLI.VServer
{
    public class Client : IDisposable
    {
        private HttpClient _HttpClient { get; }
        private StringBuilder _ApiToken { get; }
        private StringBuilder _ApiPassword { get; }

        public HttpClient HttpClient
        {
            get { return _HttpClient; }
        }

        private Client(HttpClient client, StringBuilder apiToken, StringBuilder apiPassword)
        {
            _HttpClient = client;
            _ApiToken = apiToken;
            _ApiPassword = apiPassword;
        }

        public static Client CreateWithDefaultClient(StringBuilder apiToken, StringBuilder apiPassword)
        {
            HttpClient client = new HttpClient();
            return new Client(client, apiToken, apiPassword);
        }

        public void Dispose()
        {
            _HttpClient?.Dispose();
        }
    }
}