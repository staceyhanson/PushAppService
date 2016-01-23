using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web.UI;

namespace HelloPush
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["uri"] != null)
                {
                    txtUri.Text = Request.QueryString["uri"];
                }
            }
        }

        protected void btnStandardTilePreview_Click(object sender, EventArgs e)
        {
            txtResponse.Text = DateTime.Now + Environment.NewLine + BuildStandardTile();
        }

        protected void btnStandardTile_Click(object sender, EventArgs e)
        {
            try
            {
                SendPush(BuildStandardTile(), "token", "1");
            }
            catch (Exception ex)
            {
                txtResponse.Text = "Exception caught sending update: " + ex;
            }
        }

        protected string BuildStandardTile()
        {
            string countElement = "<wp:Count";
            string titleElement = "<wp:Title";
            string backTitleElement = "<wp:BackTitle";
            string backContentElement = "<wp:BackContent";
            string backgroundImageElement = "<wp:BackgroundImage";
            string backBackgroundImage = "<wp:BackBackgroundImage";

            if (cbStandardCount.Checked)
            {
                countElement = countElement + " Action=\"Clear\">";
            }
            else
            {
                countElement = countElement + ">";
            }
            if (cbStandardTitle.Checked)
            {
                titleElement = titleElement + " Action=\"Clear\">";
            }
            else
            {
                titleElement = titleElement + ">";
            }
            if (cbStandardBackTitle.Checked)
            {
                backTitleElement = backTitleElement + " Action=\"Clear\">";
            }
            else
            {
                backTitleElement = backTitleElement + ">";
            }
            if (cbStandardBackContent.Checked)
            {
                backContentElement = backContentElement + " Action=\"Clear\">";
            }
            else
            {
                backContentElement = backContentElement + ">";
            }
            if (cbStandardBackBackgroundImage.Checked)
            {
                backBackgroundImage = backBackgroundImage + " Action=\"Clear\">";
            }
            else
            {
                backBackgroundImage = backBackgroundImage + ">";
            }
            if (cbStandardTileImage.Checked)
            {
                backgroundImageElement = backgroundImageElement + " Action=\"Clear\">";
            }
            else
            {
                backgroundImageElement = backgroundImageElement + ">";
            }

            string tileMessage = 
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                "<wp:Notification xmlns:wp=\"WPNotification\">" +
                    "<wp:Tile Id=\"" + txtStandardTileId.Text + "\">" +
                        countElement + txtStandardTileCount.Text + "</wp:Count>" +
                        titleElement + txtStandardTileTitle.Text + "</wp:Title>" +
                        backgroundImageElement + txtStandardTileImage.Text + "</wp:BackgroundImage>" +
                        backTitleElement + txtStandardTileBackTitle.Text + "</wp:BackTitle>" +
                        backContentElement + txtStandardTileBackContent.Text + "</wp:BackContent>" +
                        backBackgroundImage + txtStandardTileBackImage.Text + "</wp:BackBackgroundImage>" +
                    "</wp:Tile> " +
                "</wp:Notification>";

            return tileMessage;
        }

        protected void btnFlipTilePreview_Click(object sender, EventArgs e)
        {
            txtResponse.Text = DateTime.Now + Environment.NewLine + BuildFlipTile();
        }

        protected void btnFlipTile_Click(object sender, EventArgs e)
        {
            try
            {
                SendPush(BuildFlipTile(), "token", "1");
            }
            catch (Exception ex)
            {
                txtResponse.Text = "Exception caught sending update: " + ex;
            }
        }

        protected string BuildFlipTile()
        {
            string countElement = "<wp:Count";
            string titleElement = "<wp:Title";
            string backTitleElement = "<wp:BackTitle";
            string backContentElement = "<wp:BackContent";
            string backgroundImageElement = "<wp:BackgroundImage";
            string backBackgroundImageElement = "<wp:BackBackgroundImage";
            string wideBackContentElement = "<wp:WideBackContent";
            string wideBackgroundImageElement = "<wp:WideBackgroundImage";
            string wideBackBackgroundImageElement = "<wp:WideBackBackgroundImage";
            string smallBackgroundImageElement = "<wp:SmallBackgroundImage";

            if (cbFlipCount.Checked)
            {
                countElement = countElement + " Action=\"Clear\">";
            }
            else
            {
                countElement = countElement + ">";
            }
            if (cbFlipTitle.Checked)
            {
                titleElement = titleElement + " Action=\"Clear\">";
            }
            else
            {
                titleElement = titleElement + ">";
            }
            if (cbFlipBackTitle.Checked)
            {
                backTitleElement = backTitleElement + " Action=\"Clear\">";
            }
            else
            {
                backTitleElement = backTitleElement + ">";
            }
            if (cbFlipBackContent.Checked)
            {
                backContentElement = backContentElement + " Action=\"Clear\">";
            }
            else
            {
                backContentElement = backContentElement + ">";
            }
            if (cbFlipBackBackgroundImage.Checked)
            {
                backBackgroundImageElement = backBackgroundImageElement + " Action=\"Clear\">";
            }
            else
            {
                backBackgroundImageElement = backBackgroundImageElement + ">";
            }
            if (cbFlipImage.Checked)
            {
                backgroundImageElement = backgroundImageElement + " Action=\"Clear\">";
            }
            else
            {
                backgroundImageElement = backgroundImageElement + ">";
            }
            if (cbFlipWideBackContent.Checked)
            {
                wideBackContentElement = wideBackContentElement + " Action=\"Clear\">";
            }
            else
            {
                wideBackContentElement = wideBackContentElement + ">";
            }
            if (cbFlipWideImage.Checked)
            {
                wideBackgroundImageElement = wideBackgroundImageElement + " Action=\"Clear\">";
            }
            else
            {
                wideBackgroundImageElement = wideBackgroundImageElement + ">";
            }
            if (cbFlipWideBackBackgroundImage.Checked)
            {
                wideBackBackgroundImageElement = wideBackBackgroundImageElement + " Action=\"Clear\">";
            }
            else
            {
                wideBackBackgroundImageElement = wideBackBackgroundImageElement + ">";
            }
            if (cbFlipSmallImage.Checked)
            {
                smallBackgroundImageElement = smallBackgroundImageElement + " Action=\"Clear\">";
            }
            else
            {
                smallBackgroundImageElement = smallBackgroundImageElement + ">";
            }

            string tileMessage = 
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                "<wp:Notification xmlns:wp=\"WPNotification\">" +
                    "<wp:Tile Id=\"" + txtFlipTileId.Text + "\" Template=\"FlipTile\">" +
                         backgroundImageElement + txtFlipTileImage.Text + "</wp:BackgroundImage>" +
                         countElement + txtFlipTileCount.Text + "</wp:Count>" +
                         titleElement + txtFlipTileTitle.Text + "</wp:Title>" +
                         backTitleElement + txtFlipTileBackTitle.Text + "</wp:BackTitle>" +
                         backContentElement + txtFlipTileBackContent.Text + "</wp:BackContent>" +
                         backBackgroundImageElement + txtFlipTileBackImage.Text + "</wp:BackBackgroundImage>" +
                         smallBackgroundImageElement + txtFlipTileSmallImage.Text + "</wp:SmallBackgroundImage>" +
                         wideBackgroundImageElement + txtFlipTileWideImage.Text + "</wp:WideBackgroundImage>" +
                         wideBackContentElement + txtFlipTileWideBackContent.Text + "</wp:WideBackContent>" +
                         wideBackBackgroundImageElement + txtFlipTileWideBackImage.Text + "</wp:WideBackBackgroundImage>" +
                    "</wp:Tile> " +
                "</wp:Notification>";

            return tileMessage;
        }

        protected void btnIconicTilePreview_Click(object sender, EventArgs e)
        {
            txtResponse.Text = DateTime.Now + Environment.NewLine + BuildIconicTile();
        }

        protected void btnIconicTile_Click(object sender, EventArgs e)
        {
            try
            {
                SendPush(BuildIconicTile(), "token", "1");
            }
            catch (Exception ex)
            {
                txtResponse.Text = "Exception caught sending update: " + ex;
            }
        }

        protected string BuildIconicTile()
        {
            string countElement = "<wp:Count";
            string titleElement = "<wp:Title";
            string iconImageElement = "<wp:IconImage";
            string smallIconImageElement = "<wp:SmallIconImage";
            string wideContent1Element = "<wp:WideContent1";
            string wideContent2Element = "<wp:WideContent2";
            string wideContent3Element = "<wp:WideContent3";
            string backgroundColorElement = "<wp:BackgroundColor";

            if (cbIconicCount.Checked)
            {
                countElement = countElement + " Action=\"Clear\">";
            }
            else
            {
                countElement = countElement + ">";
            }
            if (cbIconicTitle.Checked)
            {
                titleElement = titleElement + " Action=\"Clear\">";
            }
            else
            {
                titleElement = titleElement + ">";
            }
            if (cbIconicIcon.Checked)
            {
                iconImageElement = iconImageElement + " Action=\"Clear\">";
            }
            else
            {
                iconImageElement = iconImageElement + ">";
            }
            if (cbIconicSmallIcon.Checked)
            {
                smallIconImageElement = smallIconImageElement + " Action=\"Clear\">";
            }
            else
            {
                smallIconImageElement = smallIconImageElement + ">";
            }
            if (cbIconicContent1.Checked)
            {
                wideContent1Element = wideContent1Element + " Action=\"Clear\">";
            }
            else
            {
                wideContent1Element = wideContent1Element + ">";
            }
            if (cbIconicContent2.Checked)
            {
                wideContent2Element = wideContent2Element + " Action=\"Clear\">";
            }
            else
            {
                wideContent2Element = wideContent2Element + ">";
            }
            if (cbIconicContent3.Checked)
            {
                wideContent3Element = wideContent3Element + " Action=\"Clear\">";
            }
            else
            {
                wideContent3Element = wideContent3Element + ">";
            }
            if (cbIconicBackgroundColor.Checked)
            {
                backgroundColorElement = backgroundColorElement + " Action=\"Clear\">";
            }
            else
            {
                backgroundColorElement = backgroundColorElement + ">";
            }

            string tileMessage = 
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                "<wp:Notification xmlns:wp=\"WPNotification\">" +
                    "<wp:Tile Id=\"" + txtIconicTileId.Text + "\" Template=\"IconicTile\">" +
                        countElement + txtIconicTileCount.Text + "</wp:Count>" +
                        titleElement + txtIconicTileTitle.Text + "</wp:Title>" +
                        smallIconImageElement + txtIconicTileSmallIcon.Text + "</wp:SmallIconImage>" +
                        iconImageElement + txtIconicTileIcon.Text + "</wp:IconImage>" +
                        wideContent1Element + txtIconicTileContent1.Text + "</wp:WideContent1>" +
                        wideContent2Element + txtIconicTileContent2.Text + "</wp:WideContent2>" +
                        wideContent3Element + txtIconicTileContent3.Text + "</wp:WideContent3>" +
                        backgroundColorElement + txtIconicTileBackgroundColor.Text + "</wp:BackgroundColor>" +
                    "</wp:Tile> " +
                "</wp:Notification>";

            return tileMessage;
        }

        protected void btnCycleTilePreview_Click(object sender, EventArgs e)
        {
            txtResponse.Text = DateTime.Now + Environment.NewLine + BuildCycleTile();
        }

        protected void btnCycleTile_Click(object sender, EventArgs e)
        {
            try
            {
                SendPush(BuildCycleTile(), "token", "1");
            }
            catch (Exception ex)
            {
                txtResponse.Text = "Exception caught sending update: " + ex;
            }
        }

        protected string BuildCycleTile()
        {
            string countElement = "<wp:Count";
            string titleElement = "<wp:Title";
            string cycleImage1Element = "<wp:CycleImage1";
            string cycleImage2Element = "<wp:CycleImage2";
            string cycleImage3Element = "<wp:CycleImage3";
            string cycleImage4Element = "<wp:CycleImage4";
            string cycleImage5Element = "<wp:CycleImage5";
            string cycleImage6Element = "<wp:CycleImage6";
            string cycleImage7Element = "<wp:CycleImage7";
            string cycleImage8Element = "<wp:CycleImage8";
            string cycleImage9Element = "<wp:CycleImage9";
            string smallBackgroundImageElement = "<wp:SmallBackgroundImage";

            if (cbFlipCount.Checked)
            {
                countElement = countElement + " Action=\"Clear\">";
            }
            else
            {
                countElement = countElement + ">";
            }
            if (cbCycleTitle.Checked)
            {
                titleElement = titleElement + " Action=\"Clear\">";
            }
            else
            {
                titleElement = titleElement + ">";
            }
            if (cbCycleImage1.Checked)
            {
                cycleImage1Element = cycleImage1Element + " Action=\"Clear\">";
            }
            else
            {
                cycleImage1Element = cycleImage1Element + ">";
            }
            if (cbCycleImage2.Checked)
            {
                cycleImage2Element = cycleImage2Element + " Action=\"Clear\">";
            }
            else
            {
                cycleImage2Element = cycleImage2Element + ">";
            }
            if (cbCycleImage3.Checked)
            {
                cycleImage3Element = cycleImage3Element + " Action=\"Clear\">";
            }
            else
            {
                cycleImage3Element = cycleImage3Element + ">";
            }
            if (cbCycleImage4.Checked)
            {
                cycleImage4Element = cycleImage4Element + " Action=\"Clear\">";
            }
            else
            {
                cycleImage4Element = cycleImage4Element + ">";
            }
            if (cbCycleImage5.Checked)
            {
                cycleImage5Element = cycleImage5Element + " Action=\"Clear\">";
            }
            else
            {
                cycleImage5Element = cycleImage5Element + ">";
            }
            if (cbCycleImage6.Checked)
            {
                cycleImage6Element = cycleImage6Element + " Action=\"Clear\">";
            }
            else
            {
                cycleImage6Element = cycleImage6Element + ">";
            }
            if (cbCycleImage7.Checked)
            {
                cycleImage7Element = cycleImage7Element + " Action=\"Clear\">";
            }
            else
            {
                cycleImage7Element = cycleImage7Element + ">";
            }
            if (cbCycleImage8.Checked)
            {
                cycleImage8Element = cycleImage8Element + " Action=\"Clear\">";
            }
            else
            {
                cycleImage8Element = cycleImage8Element + ">";
            }
            if (cbCycleImage9.Checked)
            {
                cycleImage9Element = cycleImage9Element + " Action=\"Clear\">";
            }
            else
            {
                cycleImage9Element = cycleImage9Element + ">";
            }
            if (cbCycleSmallImage.Checked)
            {
                smallBackgroundImageElement = smallBackgroundImageElement + " Action=\"Clear\">";
            }
            else
            {
                smallBackgroundImageElement = smallBackgroundImageElement + ">";
            }


            string tileMessage = 
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                "<wp:Notification xmlns:wp=\"WPNotification\">" +
                    "<wp:Tile Id=\"" + txtCycleTileId.Text + "\" Template=\"CycleTile\">" +
                        countElement + txtFlipTileCount.Text + "</wp:Count>" +
                        titleElement + txtFlipTileTitle.Text + "</wp:Title>" +
                        smallBackgroundImageElement + txtFlipTileSmallImage.Text + "</wp:SmallBackgroundImage>" +
                        cycleImage1Element + txtCycleTileCycleImage1.Text + "</wp:CycleImage1>" +
                        cycleImage2Element + txtCycleTileCycleImage2.Text + "</wp:CycleImage2>" +
                        cycleImage3Element + txtCycleTileCycleImage3.Text + "</wp:CycleImage3>" +
                        cycleImage4Element + txtCycleTileCycleImage4.Text + "</wp:CycleImage4>" +
                        cycleImage5Element + txtCycleTileCycleImage5.Text + "</wp:CycleImage5>" +
                        cycleImage6Element + txtCycleTileCycleImage6.Text + "</wp:CycleImage6>" +
                        cycleImage7Element + txtCycleTileCycleImage7.Text + "</wp:CycleImage7>" +
                        cycleImage8Element + txtCycleTileCycleImage8.Text + "</wp:CycleImage8>" +
                        cycleImage9Element + txtCycleTileCycleImage9.Text + "</wp:CycleImage9>" +
                    "</wp:Tile> " +
                "</wp:Notification>";

            return tileMessage;
        }

        protected void SendPush(string pushMessage, string xTarget, string xClass)
        {
            // The URI that the Push Notification Service returns to the Push Client when creating a notification channel.
            string subscriptionUri = txtUri.Text;
            var sendNotificationRequest = (HttpWebRequest) WebRequest.Create(subscriptionUri);

            // HTTP POST is the only allowed method to send the notification.
            sendNotificationRequest.Method = "POST";

            // The optional custom header X-MessageID uniquely identifies a notification message. If it is present, the // same value is returned in the notification response. It must be a string that contains a UUID.
            //sendNotificationRequest.Headers.Add("X-MessageID", "<UUID>");


            // Sets the notification payload to send.
            byte[] notificationMessage = Encoding.Default.GetBytes(pushMessage);

            // Sets the web request content length.
            sendNotificationRequest.ContentLength = notificationMessage.Length;
            sendNotificationRequest.ContentType = "text/xml";
            if (xTarget != "raw")
            {
                sendNotificationRequest.Headers.Add("X-WindowsPhone-Target", xTarget);
            }
            sendNotificationRequest.Headers.Add("X-NotificationClass", xClass);

            using (Stream requestStream = sendNotificationRequest.GetRequestStream())
            {
                requestStream.Write(notificationMessage, 0, notificationMessage.Length);
            }

            // Sends the notification and gets the response.
            var response = (HttpWebResponse) sendNotificationRequest.GetResponse();
            string notificationStatus = response.Headers["X-NotificationStatus"];
            string notificationChannelStatus = response.Headers["X-SubscriptionStatus"];
            string deviceConnectionStatus = response.Headers["X-DeviceConnectionStatus"];

            //txtResponse.Text += Environment.NewLine + notificationStatus + " | " + deviceConnectionStatus + " | " + notificationChannelStatus; 
            txtResponse.Text = DateTime.Now + Environment.NewLine + notificationStatus + " | " + deviceConnectionStatus +
                               " | " + notificationChannelStatus + Environment.NewLine + pushMessage;
        }

        protected void btnToastPreview_Click(object sender, EventArgs e)
        {
            txtResponse.Text = DateTime.Now + Environment.NewLine + BuildToast();
        }

        protected void btnToast_Click(object sender, EventArgs e)
        {
            try
            {
                SendPush(BuildToast(), "toast", "2");
            }
            catch (Exception ex)
            {
                txtResponse.Text = "Exception caught sending update: " + ex;
            }
        }

        protected string BuildToast()
        {
            string toastMessage = 
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                "<wp:Notification xmlns:wp=\"WPNotification\">" +
                    "<wp:Toast>" +
                        "<wp:Text1>" + txtToastText1.Text + "</wp:Text1>" +
                        "<wp:Text2>" + txtToastText2.Text + "</wp:Text2>" +
                        "<wp:Param>" + txtToastParam.Text + "</wp:Param>" +
                    "</wp:Toast> " +
                "</wp:Notification>";

            return toastMessage;
        }

        protected void btnRaw_Click(object sender, EventArgs e)
        {
            try
            {
                string pushClass = "3";

                if (Class3.Checked) pushClass = "3";
                if (Class4.Checked) pushClass = "4";

                string rawMessage = txtRawPayload.Text;
                if (rawMessage != "")
                {
                    SendPush(rawMessage, "raw", pushClass);
                }
                else
                {
                    txtResponse.Text = "You didn't enter anything";
                }
            }
            catch (Exception ex)
            {
                txtResponse.Text = "Exception caught sending update: " + ex;
            }
        }

        protected void btnDiyPushPreview_Click(object sender, EventArgs e)
        {
            string pushMessage = txtDiyPayload.Text;
            txtResponse.Text = pushMessage;
        }

        protected void btnDiyPush_Click(object sender, EventArgs e)
        {
            try
            {
                string pushMessage = txtDiyPayload.Text;
                if (pushMessage != "")
                {
                    string pushTarget = "token";
                    string pushClass = "1";

                    if (Tile.Checked)
                    {
                        pushTarget = "token";
                        pushClass = "1";
                    }
                    if (Toast.Checked)
                    {
                        pushTarget = "toast";
                        pushClass = "2";
                    }
                    if (Raw.Checked)
                    {
                        pushTarget = "raw";
                        pushClass = "3";
                    }
                    if (Voip.Checked)
                    {
                        pushTarget = "raw";
                        pushClass = "4";
                    }

                    SendPush(pushMessage, pushTarget, pushClass);
                }
                else
                {
                    txtResponse.Text = "You didn't enter anything";
                }
            }
            catch (Exception ex)
            {
                txtResponse.Text = "Exception caught sending update: " + ex;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DropDownList1.SelectedIndex)
            {
                case 0:
                    divStandardTile.Visible = true;
                    divFlipTile.Visible = false;
                    divIconicTile.Visible = false;
                    divCycleTile.Visible = false;
                    break;
                case 1:
                    divStandardTile.Visible = false;
                    divFlipTile.Visible = true;
                    divIconicTile.Visible = false;
                    divCycleTile.Visible = false;
                    break;
                case 2:
                    divStandardTile.Visible = false;
                    divFlipTile.Visible = false;
                    divIconicTile.Visible = true;
                    divCycleTile.Visible = false;
                    break;
                case 3:
                    divStandardTile.Visible = false;
                    divFlipTile.Visible = false;
                    divIconicTile.Visible = false;
                    divCycleTile.Visible = true;
                    break;
            }
        }
    }
}