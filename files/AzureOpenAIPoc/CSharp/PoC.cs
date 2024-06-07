using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Azure;

// Add Azure OpenAI package (Add code here)


namespace OpenAI_Chat
{  
    class Program  
    {
        public static void Main()  
        {  
            try  
            {  
                Utils.InitLog();
  
                IConfiguration config = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();
                string oaiEndpoint = config["AzureOAIEndpoint"] ?? "";
                string oaiKey = config["AzureOAIKey"] ?? "";
                string oaiModelName = config["AzureOAIModelName"] ?? "";

                // Initialize the Azure OpenAI client (Add code here)
                // This line should look like:
                //      CORRECT_TYPE client = new CORRECT_TYPE( ... );
                
                

                var functions = new Dictionary<int, Action<OpenAIClient, string>> {
                    { 1, function1 }, 
                    { 2, function2 }, 
                    { 3, function3 }, 
                    { 4, function4 }  
                };

                while (true) {
                    Console.WriteLine("1: Validate PoC\n" +
                        "2: Company chatbot\n" +
                        "3: Developer tasks\n" +
                        "4: Use company data\n" +
                        "\'quit\' to exit the program\n");
                    string userInput = (Console.ReadLine() ?? "").Trim().ToLower();                    
                    
                    if (userInput == "quit") {
                        break;
                    }
                    
                    int inputKey = int.Parse(userInput);

                    if (functions.ContainsKey(inputKey)) {
                        functions[inputKey](client, oaiModelName);
                    }
                    else {
                        Console.WriteLine("Invalid input. Please enter number 1,2,3, or 4.");
                    }
                } 
            }  
            catch (Exception ex)  
            {  
                Console.WriteLine(ex);  
            }  
        }

        // Task 1: Validate PoC
        static void function1(OpenAIClient client, string oaiModelName) {
            var promptInput = Utils.GetPromptInput("Task 1: Validate PoC\n", "sample-text.txt"); 
  
            // Build completion options object (Add code here)
            // This line should look like:
            //      CORRECT_TYPE options = new CORRECT_TYPE() { ... };
            var options =            

            Utils.WriteLog("API Parameters: ", options);

            // Send request to Azure OpenAI model (Add code here)
            // This line should look like:
            //      CORRECT_TYPE response = client.CORRECT_METHOD(...);
            var response =             

            Utils.WriteLog("Response:\n", response);  
            Console.WriteLine("Response: " + response.Choices[0].Message.Content + "\n"); 
        }

        // Task 2: Company chatbot
        static void function2(OpenAIClient client, string oaiModelName) {
            /* Uncomment this function when you're ready to work on Task 2
            var promptInput = Utils.GetPromptInput("Task 2: Company chatbot\n", "sample-text.txt"); 
  
            // Build completion options object (Add code here)
            // This line should look like:
            //      CORRECT_TYPE options = new CORRECT_TYPE() { ... };
            var options = 

            Utils.WriteLog("API Parameters: ", options);

            // Send request to Azure OpenAI model (Add code here)
            // This line should look like:
            //      CORRECT_TYPE response = client.CORRECT_METHOD(...);
            var response = 

            Utils.WriteLog("Response:\n", response);  
            Console.WriteLine("Response: " + response.Choices[0].Message.Content + "\n");
            */
        }

        // Task 3: Developer tasks
        static void function3(OpenAIClient client, string oaiModelName) {
            /* Uncomment this function when you're ready to work on Task 3
            var promptInput = Utils.GetPromptInput("Task 3: Developer tasks\n", "sample-text.txt");  
  
            // Build completion options object (Add code here)
            // This line should look like:
            //      CORRECT_TYPE options = new CORRECT_TYPE() { ... };
            var options = 

            Utils.WriteLog("API Parameters: ", options);

            // Send request to Azure OpenAI model (Add code here)
            // This line should look like:
            //      CORRECT_TYPE response = client.CORRECT_METHOD(...);
            var response = client.GetChatCompletions(options);

            Utils.WriteLog("Response:\n", response);  
            Console.WriteLine("Response: " + response.Choices[0].Message.Content + "\n");  
            */
        }

        // Task 4: Use company data
        static void function4(OpenAIClient client, string oaiModelName) {
            /* Uncomment this function when you're ready to work on Task 4
            string promptInput = Utils.GetPromptInput("Task 4: Use company data\n", "sample-text.txt");

            // Build completion options object (Add code here)
            // This section should include something like:
            //      CORRECT_TYPE options = new CORRECT_TYPE() { ... };
            var options = 

            Utils.WriteLog("API Parameters: ", options);

            // Send request to Azure OpenAI model (Add code here)
            // This line should look like:
            //      CORRECT_TYPE response = client.CORRECT_METHOD(...);
            var response =            
            
            Utils.WriteLog("Response:\n", response);  
            Console.WriteLine("Response: " + response.Choices[0].Message.Content + "\n"); 
            */
        }     
    }  
}  
