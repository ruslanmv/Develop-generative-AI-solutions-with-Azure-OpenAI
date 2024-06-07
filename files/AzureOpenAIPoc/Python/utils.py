######
# Helper functions. Do not modify code below.
######
import json
from pathlib import Path

# Set log file path
LOG_FILE_PATH = Path("../Logs/log-python.txt")

def initLogFile():
    Path("../Logs").mkdir(parents=True, exist_ok=True)

# Get user input for prompt. Do not modify.
def getPromptInput(task, availableInputFile):
    
    # Ask for user input on typing prompt or using file
    print("Would you like to type a prompt or text in file " + availableInputFile + "? (type/file)")
    input_type = input()
    text = ""

    # Get text from user if response isn't valid
    while input_type.lower() != "type" and input_type.lower() != "file":
        print("Invalid input. Please enter 'type' or 'file'.")
        input_type = input()

    if input_type.lower() == "type":
        # Ask for user input on prompt
        text = input("Please enter a prompt:\n")
    elif input_type.lower() == "file":
        # Read text from file
        print("...Reading text from " + availableInputFile + "...\n\n")
        text = open(file=availableInputFile, encoding="utf8").read()

    print("...Sending the following request to Azure OpenAI...")
    print("Request: " + text + "\n")
    writeLog(task + "\n")

    return text

# Write text to log file. Do not modify.
def writeLog(text, jsonStr=""):
    if jsonStr != "":
        text += json.dumps(jsonStr, indent=4)
        text += "\n\n"
    logfile = open(LOG_FILE_PATH, "a")
    logfile.write(text + "\n")
    logfile.close()
