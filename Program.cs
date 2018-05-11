using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace CoreMVC3 {
    public class Program {
        public static void Main (string[] args) {
            BuildWebHost (args).Run ();
        }

        public static IWebHost BuildWebHost (string[] args) =>
            WebHost.CreateDefaultBuilder (args)
            .ConfigureAppConfiguration(SetupConfiguration)
            .UseStartup<Startup> ()
            .UseKestrel()
            .Build ();

        private static void SetupConfiguration(WebHostBuilderContext ctx, IConfigurationBuilder builder)
        {
            // throw new NotImplementedException();
            builder.Sources.Clear();

            builder.AddJsonFile("config.json", false, true)
            .AddEnvironmentVariables();


        }
    }
}