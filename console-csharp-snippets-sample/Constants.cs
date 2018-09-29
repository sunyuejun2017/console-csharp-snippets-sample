using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_csharp_snippets_sample
{
    internal class Constants
    {
        public const string ClientIdForUserAuthn = "8bc07891-9e51-412c-a9ff-cbfc87b6e120";

        // Admin consent flow
        public const string Tenant = "d93cb861-a6db-4e95-9c95-69c4d22a5374";
        public const string Authority = "https://login.chinacloudapi.cn/";
        public const string AuthorityUri = "https://login.chinacloudapi.cn/" + Tenant + "/oauth2/token";
        public const string RedirectUriForAppAuthn = "https://developer.microsoft.com/en-us/graph/";
        public const string ClientIdForAppAuthn = "931c0987-d6bf-4b67-bebf-4ac0c8fb31d4";
        public const string ClientSecret = "cBSczU4bRA9W88vBIpM8QkH8KtkZdxpy+7IrhRYjINg=";

        public const string serviceResourceId = "https://microsoftgraph.chinacloudapi.cn";
        // Consent URI: 
        // https://login.chinacloudapi.cn/{tenant name}/adminconsent?client_id={application id}&state=12345&redirect_uri=https://login.microsoftonline.com
    }
}
