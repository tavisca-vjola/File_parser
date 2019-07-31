using System;
using System.Collections.Generic;
using System.IO;

namespace Http_Request
{
    public class Respone
    {

        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public  void ParseResponse(string file)
        {

            StreamReader stream = File.OpenText(file);
            string line = stream.ReadLine();
            
            dictionary.Add("http-version", line.Split(' ')[0]);
            dictionary.Add("status", line.Split(' ')[1]);
            dictionary.Add("status-code", line.Split(' ')[2]);


            while ((line = stream.ReadLine()) != null)
            {
                string [] sample=line.Split(new[] { ':' }, 2);

                string key = sample[0];
                string value = sample[1];
                dictionary.Add(key, value);

            }


        }

        public void DisplayResponse()
        {
            foreach (var dic in dictionary)
            {
                Console.WriteLine(dic.Key + dic.Value);
            }
            Console.ReadKey();
        }
    }
    
}