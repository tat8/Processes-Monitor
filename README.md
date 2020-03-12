# Processes-Monitor

In order to get current processes you can send 'Get' request to server address:

/api/process

For now, the server address is https://localhost:44335, 
so the url to get current processes is https://localhost:44335/api/process.

The response type is json


The "200 OK" response is an array of objects with the following structure:

{
	"id": 10552,
	"processName": "SearchUI",
	"virtualMemorySize64": 2238764425216
}

Description of the values in the response:

"id" - int - the unique identifier for the associated process

"processName" - string - the name of the process

"virtualMemorySize64" - long - the amount of the virtual memory, in bytes, allocated for the associated process


The "400 Bad Request" response is a string containg the exception message.


