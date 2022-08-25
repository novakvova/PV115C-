using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EmailLib.Services
{
    public class SMSService
    {
        public void Send(string phone, string text)
        {
            string apiKey = "ua6e68580ab06ebf20ef30f5ab3ed666f1e0acd313d52d4dfdb92b695a69ba60ec691c";
            string url = $"https://api.mobizon.ua/service/message/sendsmsmessage?recipient={phone}&text={text}&apiKey={apiKey}";

            // Create a request for the URL.
            WebRequest request = WebRequest.Create(url);
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;

            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            // Get the stream containing content returned by the server.
            // The using block ensures the stream is automatically closed.
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                Console.WriteLine(responseFromServer);
            }

            // Close the response.
            response.Close();

        }
    }
}
