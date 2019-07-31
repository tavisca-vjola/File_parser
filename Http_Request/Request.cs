using System;
using System.Collections.Generic;
using System.IO;

namespace Http_Request
{
    public class Request
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();

        public void ParseRequest(string file)
        {
           
            StreamReader stream = File.OpenText(file);
            string line=stream.ReadLine();
            dict.Add(line.Split(' ')[0],line.Split(' ')[1]);
            dict.Add("Version",line.Split(' ')[2]);

            
            while((line=stream.ReadLine())!= null)
            {
                string key = line.Split(':')[0];
                string value = line.Split(':')[1];
                dict.Add(key, value);

            }
           

        }

        public void DisplayRequest()
        {
           foreach( var dic in dict )
            {
                Console.WriteLine(dic.Key+dic.Value);
            }
        }
    }
}