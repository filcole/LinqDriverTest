REM CrmSvcUtil.exe /url:https://<serverName>/<organizationName>/XRMServices/2011/Organization.svc    /out:<outputFilename>.cs /username:<username> /password:<password> /domain:<domainName>    /namespace:<outputNamespace> /serviceContextName:<serviceContextName>  
"c:\crm\SDK 9.1.0.54\CoreTools\CrmSvcUtil.exe" ^
  /url:https://pcole1020.api.crm11.dynamics.com/XRMServices/2011/Organization.svc ^
  /out:EntityModel.cs ^
  /interactivelogin ^
  /namespace:dxc.client.EntityModel ^
  /serviceContextName:CrmServiceContext  
