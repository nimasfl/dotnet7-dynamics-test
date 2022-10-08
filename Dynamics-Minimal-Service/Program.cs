using Data8.PowerPlatform.Dataverse.Client;
using Microsoft.Crm.Sdk.Messages;

var host = ""; // crm.example.com
var organization = "";// contoso
var _username = ""; // active directory username which has access to dynamics 365
var password = ""; // active directory user's password
var domain = ""; // active directory dimain
var serviceUrl = $"https://{host}/{organization}/XRMServices/2011/Organization.svc";
var username = $"{domain}\\{_username}";
var service = new OnPremiseClient(serviceUrl, username, password);
var result = service.Execute(new WhoAmIRequest());
Console.WriteLine(result.Results.FirstOrDefault(r => r.Key == "UserId").Value.ToString());
