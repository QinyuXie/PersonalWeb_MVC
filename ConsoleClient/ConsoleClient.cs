﻿
/*
 * - Based on Asp.Net Core Framework, this client project generates
 *   dynamic link library that can be hosted by Visual Studio or
 *   dotnet CLI.
 * - It provides options via its command line, e.g.:
 *   - url /fl            displays list of files in server's FileStore
 *   - url /up fileSpec   uploades fileSpec to FileStore
 *   - url /dn n          downloads nth file in FileStore
 *   - url /dl n          deletes nth file in FileStore
 */

using System;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json.Serialization;  // must install Newtonsoft package from Nuget
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


namespace ConsoleClient
{
    public class ConsoleClient
    {
        public HttpClient client { get; set; }

        private string baseUrl_;

        public ConsoleClient()
        {
        }

        ConsoleClient(string url)
        {
            baseUrl_ = url;
            client = new HttpClient();
        }


        // post comments
        public async Task<HttpResponseMessage> PostComm(string FromUserName, string CommContent)
        {
            HttpContent postContent = new FormUrlEncodedContent(new Dictionary<string, string>()
           {
              {"FromUserNm", FromUserName},
              {"CommentContent", CommContent}
           });
            return await client.PostAsync(baseUrl_, postContent);
        }

        //----< get list of files in server FileStorage >----------

        public async Task<IEnumerable<string>> GetCommList()
        {
            HttpResponseMessage resp = await client.GetAsync(baseUrl_);
            var comments = new List<string>();
            if (resp.IsSuccessStatusCode)
            {
                var json = await resp.Content.ReadAsStringAsync();
                JArray jArr = (JArray)JsonConvert.DeserializeObject(json);
                foreach (var item in jArr)
                    comments.Add(item.ToString());
            }
            return comments;
        }
        //----< download the id-th file >--------------------------

        public async Task<HttpResponseMessage> GetComment(int id)
        {
            return await client.GetAsync(baseUrl_ + "/" + id.ToString());
        }
        //----< delete the id-th file from FileStorage >-----------

        public async Task<HttpResponseMessage> DeleteComm(int id)
        {
            return await client.DeleteAsync(baseUrl_ + "/" + id.ToString());
        }
        //----< usage message shown if command line invalid >------

        static void showUsage()
        {
            Console.Write("\n  Command line syntax error: expected usage:\n");
            Console.Write("\n    http[s]://machine:port /option [filespec]\n\n");
        }
        //----< validate the command line >------------------------

        static bool parseCommandLine(string[] args)
        {
            if (args.Length < 2)
            {
                showUsage();
                return false;
            }
            if (args[0].Substring(0, 4) != "http")
            {
                showUsage();
                return false;
            }
            if (args[1][0] != '/')
            {
                showUsage();
                return false;
            }
            return true;
        }
        //----< display command line arguments >-------------------

        static void showCommandLine(string[] args)
        {
            string arg0 = args[0];
            string arg1 = args[1];
            string arg2;
            if (args.Length == 3)
                arg2 = args[2];
            else
                arg2 = "";
            Console.Write("\n  CommandLine: {0} {1} {2}", arg0, arg1, arg2);
        }

        static void Main(string[] args)
        {
            Console.Write("\n  CoreConsoleClient");
            Console.Write("\n ===================\n");

            if (!parseCommandLine(args))
            {
                return;
            }
            Console.Write("Press key to start: ");
            Console.ReadKey();

            string url = args[0];
            ConsoleClient client = new ConsoleClient(url);

            showCommandLine(args);
            Console.Write("\n  sending request to {0}\n", url);

            switch (args[1])
            {
                case "/get":
                    Task<IEnumerable<string>> comml = client.GetCommList();
                    var resultfl = comml.Result;
                    foreach (var item in resultfl)
                    {
                        Console.Write("\n  {0}", item);
                    }
                    break;
                case "/post":
                    Task<HttpResponseMessage> tup = client.PostComm(args[2], args[3]);
                    Console.Write(tup.Result);
                    break;
                case "/get/id":
                    int get_id = Int32.Parse(args[2]);
                    Task<HttpResponseMessage> tdn = client.GetComment(get_id);
                    Console.Write(tdn.Result);
                    break;
                case "/delete/id":
                    int id = Int32.Parse(args[2]);
                    Task<HttpResponseMessage> res = client.DeleteComm(id);
                    Console.Write(res.Result);
           
                    break;
            }

            Console.WriteLine("\n  Press Key to exit: ");
            Console.ReadKey();
        }
    }


}
