using System;
using System.Net;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Azure;

// Utilities for the Azure OpenAI chat app. Do not modify
namespace OpenAI_Chat  
{
    class Utils
    {
        // Set log file path  
        static readonly string LOG_FILE_PATH = "../Logs/log-csharp.txt";

        // Initialize log file
        public static void InitLog()
        {
            if(!Directory.Exists("../Logs"))
                Directory.CreateDirectory("../Logs");
            if (!File.Exists(LOG_FILE_PATH))  
                File.Create(LOG_FILE_PATH).Close();
        }

        // Write text to log file. Do not modify.  
        public static void WriteLog(string text, object jsonObj = null)  
        {
            if (jsonObj != null)
            {
                text += JsonSerializer.Serialize(jsonObj, new JsonSerializerOptions { 
                    WriteIndented = true, 
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull });
                text += "\n\n";
            }
            File.AppendAllText(LOG_FILE_PATH, text);  
        }

        // Get prompt input from user. Do not modify.
        public static string GetPromptInput(string task, string availableInputFile)  
        {  
            // Ask for user input on typing prompt or using file  
            Console.WriteLine("Would you like to type a prompt or use a file? (type/file)");  
            string inputType = (Console.ReadLine() ?? "").ToLower();  
            string text = "";  
  
            // Get text from user if response isn't valid  
            while (inputType != "type" && inputType != "file")  
            {  
                Console.WriteLine("Invalid input. Please enter 'type' or 'file'.");  
                inputType = (Console.ReadLine() ?? "").ToLower();  
            }  
  
            if (inputType == "type")  
            {  
                // Ask for user input on prompt  
                Console.WriteLine("Please enter a prompt:");  
                text = Console.ReadLine() ?? "";  
            }  
            else if (inputType == "file")  
            {  
                // Read text from file  
                Console.WriteLine("...Reading text from file...\n\n");  
                text = File.ReadAllText(availableInputFile);  
            }
            
            Console.WriteLine("...Sending the following request to Azure OpenAI endpoint...");
            Console.WriteLine("Request: " + text + "\n");
            WriteLog(task);
            
            return text;  
        }  
    }   
}  