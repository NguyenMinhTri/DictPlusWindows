using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Web;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.Threading;
namespace Tu_Dien_1._1
{
    class TranslatorBing
    {
     static string headerValue="";
        public TranslatorBing()
        {
            AdmAccessToken admToken;
         
            //Get Client Id and Client Secret from https://datamarket.azure.com/developer/applications/
            //Refer obtaining AccessToken (http://msdn.microsoft.com/en-us/library/hh454950.aspx) 
            AdmAuthentication admAuth = new AdmAuthentication("001af0d8-d941-4b29-9b02-23b70b720816", "xTzEDgfCZZqMecArd9Opsk2PeXttJCfL1F9U3utvVv0");
            try
            {
                admToken = admAuth.GetAccessToken();
                DateTime tokenReceived = DateTime.Now;
                // Create a header with the access_token property of the returned token
                headerValue = "Bearer " + admToken.access_token;
               
            }
            catch
            {
                FormSOHA.isBing = false;
            }
        }
        public string Translator(string inPUT, string from, string to)
        {
            if (headerValue == "")
            {
                FormSOHA.isBing = false;
                return "No data or error";
            }
            try
            {
                // Add TranslatorService as a service reference, Address:http://api.microsofttranslator.com/V2/Soap.svc
                TranslatorService.LanguageServiceClient client = new TranslatorService.LanguageServiceClient();
                //Set Authorization header before sending the request
                HttpRequestMessageProperty httpRequestProperty = new HttpRequestMessageProperty();
                httpRequestProperty.Method = "POST";
                httpRequestProperty.Headers.Add("Authorization", headerValue);
                // Creates a block within which an OperationContext object is in scope.
                using (OperationContextScope scope = new OperationContextScope(client.InnerChannel))
                {
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = httpRequestProperty;

                    string translationResult;
                    //Keep appId parameter blank as we are sending access token in authorization header.
                    translationResult = client.Translate("", inPUT, from, to);
                    return translationResult;
                }
            }
            catch
            {
                FormSOHA.isBing = false;
                return "No data or error";
            }
        }
        public string TranslateMethod(string inPUT)
        {
            if (headerValue == "")
            {
                FormSOHA.isBing = false;
                return "No data or error";
            }
            try
            {
                // Add TranslatorService as a service reference, Address:http://api.microsofttranslator.com/V2/Soap.svc
                TranslatorService.LanguageServiceClient client = new TranslatorService.LanguageServiceClient();
                //Set Authorization header before sending the request
                HttpRequestMessageProperty httpRequestProperty = new HttpRequestMessageProperty();
                httpRequestProperty.Method = "POST";
                httpRequestProperty.Headers.Add("Authorization", headerValue);
                // Creates a block within which an OperationContext object is in scope.
                using (OperationContextScope scope = new OperationContextScope(client.InnerChannel))
                {
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = httpRequestProperty;
                    string translationResult;
                    //Keep appId parameter blank as we are sending access token in authorization header.
                    translationResult = client.Translate("", inPUT, "en", "vi");
                    return translationResult;
                }
            }
            catch
            {
                FormSOHA.isBing = false;
                return "No data or error";
            }
        }
        [DataContract]
        public class AdmAccessToken
        {
            [DataMember]
            public string access_token { get; set; }
            [DataMember]
            public string token_type { get; set; }
            [DataMember]
            public string expires_in { get; set; }
            [DataMember]
            public string scope { get; set; }
        }
        public class AdmAuthentication
        {
            public static readonly string DatamarketAccessUri = "https://datamarket.accesscontrol.windows.net/v2/OAuth2-13";
            private string clientId;
            private string clientSecret;
            private string request;
            private AdmAccessToken token;
            private Timer accessTokenRenewer;
            //Access token expires every 10 minutes. Renew it every 9 minutes only.
            private const int RefreshTokenDuration = 9;
            public AdmAuthentication(string clientId, string clientSecret)
            {
                this.clientId = clientId;
                this.clientSecret = clientSecret;
                //If clientid or client secret has special characters, encode before sending request
                this.request = string.Format("grant_type=client_credentials&client_id={0}&client_secret={1}&scope=http://api.microsofttranslator.com", HttpUtility.UrlEncode(clientId), HttpUtility.UrlEncode(clientSecret));
                this.token = HttpPost(DatamarketAccessUri, this.request);
                //renew the token every specified minutes
                accessTokenRenewer = new Timer(new TimerCallback(OnTokenExpiredCallback), this, TimeSpan.FromMinutes(RefreshTokenDuration), TimeSpan.FromMilliseconds(-1));
            }
            public AdmAccessToken GetAccessToken()
            {
                return this.token;
            }
            private void RenewAccessToken()
            {
                AdmAccessToken newAccessToken = HttpPost(DatamarketAccessUri, this.request);
                //swap the new token with old one
                //Note: the swap is thread unsafe
                this.token = newAccessToken;
               
            }
            private void OnTokenExpiredCallback(object stateInfo)
            {
                try
                {
                    RenewAccessToken();
                }
                catch 
                {
                    
                }
                finally
                {
                    try
                    {
                        accessTokenRenewer.Change(TimeSpan.FromMinutes(RefreshTokenDuration), TimeSpan.FromMilliseconds(-1));
                    }
                    catch 
                    {
                    }
                }
            }
            private AdmAccessToken HttpPost(string DatamarketAccessUri, string requestDetails)
            {
                //Prepare OAuth request 
                WebRequest webRequest = WebRequest.Create(DatamarketAccessUri);
                webRequest.ContentType = "application/x-www-form-urlencoded";
                webRequest.Method = "POST";
                byte[] bytes = Encoding.ASCII.GetBytes(requestDetails);
                webRequest.ContentLength = bytes.Length;
                using (Stream outputStream = webRequest.GetRequestStream())
                {
                    outputStream.Write(bytes, 0, bytes.Length);
                }
                using (WebResponse webResponse = webRequest.GetResponse())
                {
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(AdmAccessToken));
                    //Get deserialized object from JSON stream
                    AdmAccessToken token = (AdmAccessToken)serializer.ReadObject(webResponse.GetResponseStream());
                    return token;
                }
            }
          
        }
    }
}

