using System;
using System.Collections.Generic;
using CluedIn.Core.Net.Mail;
using CluedIn.Core.Providers;

namespace CluedIn.Crawling.ServiceNow.Core
{
    public class ServiceNowConstants
    {
        public struct KeyName
        {
            public const string Username = nameof(Username);
            public const string Password = nameof(Password);
        }

        // TODO Complete the following section
        public const string CrawlerDescription = "ServiceNow";
        public const string Instructions = "Provide authentication instructions here, if applicable";
        public const IntegrationType Type = IntegrationType.Cloud;
        public const string Uri = "http://www.servicenow.com"; //Uri of remote tool if applicable

        // To change the icon see embedded resource
        // src\ServiceNow.Provider\Resources\cluedin.png
        public const string IconResourceName = "Resources.servicenow.png";

        public static IList<string> ServiceType = new List<string> { "" };
        public static IList<string> Aliases = new List<string> { "" };
        public const string Category = "";
        public const string Details = "";
        public static AuthMethods AuthMethods = new AuthMethods()
        {
            token = new Control[]
            {
                new Control()
                {
                    displayName = "Username",
                    isRequired = true,
                    name = "Username",
                    type = "text"
                },
                new Control()
                {
                    displayName = "Password",
                    isRequired = true,
                    name = "Password",
                    type = "password"
                }

            }
        };


        public const bool SupportsConfiguration = true;
        public const bool SupportsWebHooks = false;
        public const bool SupportsAutomaticWebhookCreation = true;

        public const bool RequiresAppInstall = false;
        public const string AppInstallUrl = null;
        public const string ReAuthEndpoint = null;

        #region Autogenerated constants
        public const string CodeOrigin = "ServiceNow";
        public const string ProviderRootCodeValue = "ServiceNow";
        public const string CrawlerName = "ServiceNowCrawler";
        public const string CrawlerComponentName = "ServiceNowCrawler";
        public static readonly Guid ProviderId = Guid.Parse("24857784-6f05-4f26-b11d-83732e09069a");
        public const string ProviderName = "ServiceNow";

        


        public static readonly ComponentEmailDetails ComponentEmailDetails = new ComponentEmailDetails
        {
            Features = new Dictionary<string, string>
            {
                                       { "Tracking",        "Expenses and Invoices against customers" },
                                       { "Intelligence",    "Aggregate types of invoices and expenses against customers and companies." }
                                   },
            Icon = ProviderIconFactory.CreateConnectorUri(ProviderId),
            ProviderName = ProviderName,
            ProviderId = ProviderId,
            Webhooks = SupportsWebHooks
        };

        public static IProviderMetadata CreateProviderMetadata()
        {
            return new ProviderMetadata
            {
                Id = ProviderId,
                ComponentName = CrawlerName,
                Name = ProviderName,
                Type = Type.ToString(),
                SupportsConfiguration = SupportsConfiguration,
                SupportsWebHooks = SupportsWebHooks,
                SupportsAutomaticWebhookCreation = SupportsAutomaticWebhookCreation,
                RequiresAppInstall = RequiresAppInstall,
                AppInstallUrl = AppInstallUrl,
                ReAuthEndpoint = ReAuthEndpoint,
                ComponentEmailDetails = ComponentEmailDetails
            };
        }
        #endregion
    }
}