using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebRole1.WNS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var sendNow = Request.QueryString["sendNow"];
            if (sendNow != null && sendNow == "true")
            {
                Uri tempUri = new Uri(Request.QueryString["uri"]);
                string sUri = "https://bay.notify.windows.com/?token=";
                string sQuery = tempUri.Query;
                string sToken = HttpUtility.ParseQueryString(sQuery).Get("token").Replace(" ", "+");
                string uri = sUri + WebUtility.UrlEncode(sToken);

                var secret = Request.QueryString["secret"];
                //var secretIn = WebUtility.UrlDecode(Request.QueryString["secret"]);
                //var secretOut = secretIn.Replace(" ", "+");
                var sid = WebUtility.UrlDecode(Request.QueryString["sid"]);
                var payload = WebUtility.UrlDecode(Request.QueryString["payload"]);
                var notificationType = WebUtility.UrlDecode(Request.QueryString["notificationType"]);
                var contentType = WebUtility.UrlDecode(Request.QueryString["contentType"]);

                //if (notificationType == "tile") {PushTypeList.SelectedIndex = 0;}
                //if (notificationType == "toast") { PushTypeList.SelectedIndex = 1; }
                //if (notificationType == "badge") { PushTypeList.SelectedIndex = 4; }


                //do immediate post
                txtResponse.Text = PostToWns(
                    secret,
                    sid,
                    uri,
                    payload,
                    notificationType,
                    contentType);

            }
            if (!IsPostBack)
            {
                if (Request.QueryString["notificationType"] != null)
                {
                    switch (Request.QueryString["notificationType"])
                    {
                        case "wns/tile":
                            PushTypeList.SelectedIndex = 0;
                            break;
                        case "wns/toast":
                            PushTypeList.SelectedIndex = 1;
                            break;
                        case "wns/badge":
                            PushTypeList.SelectedIndex = 4;
                            break;
                        case "wns/raw":
                            PushTypeList.SelectedIndex = 5;
                            break;
                        default:
                            throw new Exception();
                    }
                }

                if (Request.QueryString["sid"] != null)
                {
                    txtSid.Text = Request.QueryString["sid"];
                }
                else
                {
                    var cookie = Request.Cookies["Sid"];
                    if (cookie != null)
                    {
                        txtSid.Text = cookie.Value;
                    }
                }

                if (Request.QueryString["secret"] != null)
                {
                    txtSecret.Text = Request.QueryString["secret"];
                }
                else
                {
                    var secret = Request.Cookies["Secret"];
                    if (secret != null)
                    {
                        txtSecret.Text = secret.Value;
                    }
                }

                if (Request.QueryString["xml"] != null)
                {
                    txtDiyPayload.Text = Request.QueryString["xml"];
                }

                if (Request.QueryString["uri"] != null)
                {
                    Uri tempUri = new Uri(Request.QueryString["uri"]);
                    string sUri = "https://bay.notify.windows.com/?token=";
                    string sQuery = tempUri.Query;
                    string sToken = HttpUtility.ParseQueryString(sQuery).Get("token").Replace(" ", "+");

                    string uri = sUri + WebUtility.UrlEncode(sToken);
                    txtUri.Text = uri;
                }


            }
        }

        protected void PushTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (PushTypeList.SelectedIndex)
            {
                case 0:
                    divXML.Visible = true;
                    divGroupAndTagList.Visible = false;
                    txtDiyPayload.Text =
                        "<tile>" +
                            "<visual version=\"2\">" +
                                "<binding template=\"TileSquare150x150Text01\" fallback=\"TileSquareText01\">" +
                                    "<text id=\"1\">Text Field 1 (larger text)</text>" +
                                    "<text id=\"2\">Text Field 2</text>" +
                                    "<text id=\"3\">Text Field 3</text>" +
                                    "<text id=\"4\">Text Field 4</text>" +
                                "</binding>" +
                            "</visual>" +
                        "</tile>";

                    break;
                case 1:
                    divXML.Visible = true;
                    divGroupAndTagList.Visible = true;
                    txtDiyPayload.Text =
                        "<toast>" +
                            "<visual>" +
                                "<binding template=\"ToastText02\">" +
                                    "<text id=\"1\">headlineText</text>" +
                                    "<text id=\"2\">bodyText</text>" +
                                "</binding>" +
                            "</visual>" +
                        "</toast>";

                    break;
                case 2:
                    divXML.Visible = true;
                    divGroupAndTagList.Visible = true;
                    txtDiyPayload.Text =
                        "<toast>" +
                            "<visual>" +
                                "<binding template=\"ToastText02\">" +
                                    "<text id=\"1\">Shhhhh...</text>" +
                                    "<text id=\"2\">So ghostly...</text>" +
                                "</binding>" +
                            "</visual>" +
                        "</toast>";

                    break;
                case 3:
                    divXML.Visible = false;
                    divGroupAndTagList.Visible = true;

                    break;

                case 4:
                    divXML.Visible = true;
                    divGroupAndTagList.Visible = false;
                    txtDiyPayload.Text = "<badge value=\"99\"/>";

                    break;

                case 5:
                    divXML.Visible = true;
                    divGroupAndTagList.Visible = false;
                    txtDiyPayload.Text = "";

                    break;
            }
        }

        protected void GroupAndTagList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (GroupAndTagList.SelectedIndex)
            {
                case 0:
                    divGroupAndTag.Visible = true;
                    divGroup.Visible = false;
                    divTag.Visible = false;

                    break;
                case 1:
                    divGroup.Visible = true;
                    divGroupAndTag.Visible = false;
                    divTag.Visible = false;

                    break;
                case 2:
                    divTag.Visible = true;
                    divGroupAndTag.Visible = false;
                    divGroup.Visible = false;

                    break;
                case 3:
                    divGroupAndTag.Visible = false;
                    divGroup.Visible = false;
                    divTag.Visible = false;

                    break;
            }
        }

        protected void btnDiyPushPreview_Click(object sender, EventArgs e)
        {
            string pushMessage = txtDiyPayload.Text.ToString();
            txtResponse.Text = pushMessage;
        }

        protected void btnDiyPush_Click(object sender, EventArgs e)
        {
            try
            {
                string uri = txtUri.Text;

                string xml = txtDiyPayload.Text;

                if (xml != "")
                {
                    string contentType = null;
                    string notificationType = null;
                    switch (PushTypeList.SelectedIndex)
                    {
                        case (0):
                            notificationType = "wns/tile"; contentType = "text/xml";
                            break;
                        case (1):
                            notificationType = "wns/toast"; contentType = "text/xml";
                            break;
                        case (2):
                            notificationType = "wns/toast"; contentType = "text/xml";
                            break;
                        case (3):
                            notificationType = "wns/toast"; contentType = "text/xml";
                            break;
                        case (4):
                            notificationType = "wns/badge"; contentType = "text/xml";
                            break;
                        case (5):
                            notificationType = "wns/raw"; contentType = "application/octet-stream";
                            break;
                        default:
                            throw new Exception("Push type not recognized");
                    }

                    var sidCookie = new HttpCookie("Sid") { Value = txtSid.Text, Expires = DateTime.Now.AddDays(7) };
                    Response.Cookies.Add(sidCookie);

                    var secretCookie = new HttpCookie("Secret") { Value = txtSecret.Text, Expires = DateTime.Now.AddDays(7) };
                    Response.Cookies.Add(secretCookie);

                    txtResponse.Text = PostToWns(
                        txtSecret.Text,
                        txtSid.Text,
                        uri,
                        xml,
                        notificationType,
                        contentType);

                }
                else
                {
                    txtResponse.Text += "You didn't enter anything";
                }

            }
            catch (Exception ex)
            {
                txtResponse.Text += "Exception caught sending update: " + ex.ToString();
            }
        }

        // Post to WNS
        public string PostToWns(string secret, string sid, string uri, string xml, string notificationType, string contentType)
        {
            try
            {
                // You should cache this access token.
                var accessToken = GetAccessToken(secret, sid);
                byte[] contentInBytes = Encoding.UTF8.GetBytes(xml);

                var request = HttpWebRequest.Create(uri) as HttpWebRequest;

                request.Headers.Add("Authorization", String.Format("Bearer {0}", accessToken.AccessToken));

                if (txtTTL.Text != "") { request.Headers.Add("X-WNS-TTL", txtTTL.Text); }

                if (notificationType == "wns/toast")
                {
                    request.Method = "POST";
                    request.Headers.Add("X-WNS-Type", notificationType);
                    if (GroupAndTagList.SelectedIndex == 0)
                    {
                        request.Headers.Add("X-WNS-Group", txtGroup.Text);
                        request.Headers.Add("X-WNS-Tag", txtTag.Text);

                    }
                    else if (GroupAndTagList.SelectedIndex == 1) { request.Headers.Add("X-WNS-Group", txtGroupOnly.Text); }
                    else if (GroupAndTagList.SelectedIndex == 2) { request.Headers.Add("X-WNS-Tag", txtTagOnly.Text); }
                    request.ContentType = contentType;
                    if (PushTypeList.SelectedIndex == 2) { request.Headers.Add("X-WNS-SuppressPopup", "true"); }

                    using (Stream requestStream = request.GetRequestStream())
                        requestStream.Write(contentInBytes, 0, contentInBytes.Length);

                }
                else if (PushTypeList.SelectedIndex == 3)
                {
                    string deleteArgs = "type=wns/toast;";
                    if (GroupAndTagList.SelectedIndex == 0) { deleteArgs += ("group=" + txtGroup.Text + ";tag=" + txtTag.Text); }
                    else if (GroupAndTagList.SelectedIndex == 1) { deleteArgs += ("group=" + txtGroupOnly.Text); }
                    else if (GroupAndTagList.SelectedIndex == 2) { deleteArgs += ("tag=" + txtTagOnly.Text); }
                    else if (GroupAndTagList.SelectedIndex == 3) { deleteArgs += "all"; }

                    request.Method = "DELETE";
                    request.Headers.Add("X-WNS-Match", deleteArgs);

                    //using (Stream requestStream = request.GetRequestStream())
                    //    requestStream.Write(contentInBytes, 0, contentInBytes.Length);
                }
                else
                {
                    request.Method = "POST";
                    request.Headers.Add("X-WNS-Type", notificationType);
                    request.ContentType = contentType;

                    using (Stream requestStream = request.GetRequestStream())
                        requestStream.Write(contentInBytes, 0, contentInBytes.Length);
                }
                using (var webResponse = (HttpWebResponse)request.GetResponse())
                {
                    return webResponse.StatusCode.ToString();
                }

            }
            catch (WebException webException)
            {
                var header = webException.Response.Headers["WWW-Authenticate"];
                if (header != null && header.Contains("Token expired"))
                {
                    // This function call doesn't seem to store the returned accessToken
                    GetAccessToken(secret, sid);

                    // We suggest that you implement a maximum retry policy.
                    return PostToWns(uri, xml, secret, sid, notificationType, contentType);
                }
                else
                {
                    // Log the response
                    return "EXCEPTION: " + webException.Message + "\n" + webException.Response.Headers.ToString();
                }
            }
            catch (Exception ex)
            {
                return "EXCEPTION: " + ex.Message;
            }
        }

        // Authorization
        [DataContract]
        public class OAuthToken
        {
            [DataMember(Name = "access_token")]
            public string AccessToken { get; set; }
            [DataMember(Name = "token_type")]
            public string TokenType { get; set; }
        }


        private OAuthToken GetOAuthTokenFromJson(string jsonString)
        {
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(jsonString)))
            {
                var ser = new DataContractJsonSerializer(typeof(OAuthToken));
                return (OAuthToken)ser.ReadObject(ms);
            }
        }

        protected OAuthToken GetAccessToken(string secret, string sid)
        {
            var urlEncodedSecret = HttpUtility.UrlEncode(secret);
            var urlEncodedSid = HttpUtility.UrlEncode(sid);

            var body = string.Format("grant_type=client_credentials&client_id={0}&client_secret={1}&scope=notify.windows.com",
                                        urlEncodedSid,
                                        urlEncodedSecret);

            string response;
            using (var client = new WebClient())
            {
                client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                try
                {
                    response = client.UploadString("https://login.live.com/accesstoken.srf", body);
                }
                catch (WebException webException)
                {
                    throw new Exception("Couldn't get OAuthToken: " + webException.Message + " Make sure your appSID is formatted correctly. Did you include \"ms-app:\\\\\" before your appSID?");
                }
            }

            return GetOAuthTokenFromJson(response);
        }
        
    }
}