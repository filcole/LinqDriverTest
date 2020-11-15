using dxc.client.CEEntity;
using Microsoft.PowerPlatform.Cds.Client;
using System;
using System.Linq;
using Microsoft.Xrm.Sdk.Query;

namespace CdsServiceClientLinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var uri = new Uri("https://pcole1020.crm11.dynamics.com/");

            var clientId = "b74de910-18b6-4eb7-aeca-154ca98115e8";
            var clientSecret = "REPLACEME";

            var client = new CdsServiceClient(uri, clientId, clientSecret, true, "");

            if (!client.IsReady)
            {
                Console.WriteLine("CDS Service Client not ready!");
                Console.ReadLine();
                return;
            }

            using (var context = new CrmServiceContext(client))
            {
                // Check account exists just by returning Id
                // Use fiddler here to notice that all columns of the Account record are returned - yet we only asked for Id 
                Guid id = (from a in context.AccountSet
                           where a.Name.Equals("Wonka Chocolate Factory")
                           select a.Id).FirstOrDefault();

                Console.WriteLine($"id = {id}");

                // Check account exists just by returning AccountId
                // Note that we have to return a nullable Guid - even though we know this will never be null due to it
                // being the primary field/attribute/column.
                // Use fiddler here ot notice that only the Id and accountId columns are returned.
                Guid? accountId = (from a in context.AccountSet
                                   where a.Name.Equals("Wonka Chocolate Factory")
                                   select a.AccountId).FirstOrDefault();

                Console.WriteLine($"accountId = {accountId}");
                Console.ReadLine();
            }
        }
    }
}
