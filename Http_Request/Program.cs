using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Http_Request
{
    class Program
    {
        static void Main(string[] args)
        {
            Request request = new Request();
            request.ParseRequest("Request.txt");
            request.DisplayRequest();
            Respone response = new Respone();
            response.ParseResponse("Response.txt");
            response.DisplayResponse();

        }
    }
}
