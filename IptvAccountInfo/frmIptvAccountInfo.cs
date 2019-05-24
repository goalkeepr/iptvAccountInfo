using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;

namespace IptvAccountInfo
{
    public partial class frmIptvAccountInfo : Form
    {
        private string _portalUrl;
        private string _userId;
        private string _password;
        private IptvAccount _iptvAccount;

        public frmIptvAccountInfo()
        {
            InitializeComponent();
        }

        private void FrmIptvAccountInfo_Load(object sender, EventArgs e)
        {
            cboInfoType.SelectedIndex = 0;
        }

        private void CboInfoType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboInfoType.SelectedIndex == 0)
            {
                lblM3uUrl.Visible = true;
                txtM3uUrl.Visible = true;
                lblPortalUrl.Visible = false;
                lblUserId.Visible = false;
                lblPassword.Visible = false;
                txtPortalUrl.Visible = false;
                txtUserId.Visible = false;
                txtPassword.Visible = false;
            }
            else
            {
                lblM3uUrl.Visible = false;
                txtM3uUrl.Visible = false;
                lblPortalUrl.Visible = true;
                lblUserId.Visible = true;
                lblPassword.Visible = true;
                txtPortalUrl.Visible = true;
                txtUserId.Visible = true;
                txtPassword.Visible = true;
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            lblTsM3u.Text = "--------";
            lblHlsM3u.Text = "--------";
            lblXmlEpg.Text = "--------";
            lblWatchOnline.Text = "--------";
            lblTsM3uShort.Text = "--------";
            lblHlsM3uShort.Text = "--------";
            lblXmlEpgShort.Text = "--------";

            try
            {
                PopulateAccountVariables();

                PopulateAccountInformation();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops, wasn't prepared for this situation.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateAccountInformation()
        {
            using (WebClient webClient = new WebClient())
            {
                var jsonFile = webClient.DownloadString(ApiUrl);
                _iptvAccount = IptvAccount.FromJson(jsonFile);

                lblCreatedDate.Text = string.Format("{0:yyyy-MM-dd}", EpochToDate(_iptvAccount.UserInfo.CreatedAt));
                lblExpiresDate.Text = string.Format("{0:yyyy-MM-dd}", EpochToDate(_iptvAccount.UserInfo.ExpDate));
                lblAccountStatus.Text = _iptvAccount.UserInfo.Status;
                lblOutputFormats.Text = string.Join(", ", _iptvAccount.UserInfo.AllowedOutputFormats);

                lblActiveConnections.Text = _iptvAccount.UserInfo.ActiveCons.ToString();
                lblMaxConnections.Text = _iptvAccount.UserInfo.MaxConnections.ToString();

                lblLiveCategories.Text = ((_iptvAccount.Categories.Live != null) ? _iptvAccount.Categories.Live.Count() : 0).ToString("N0");
                lblMovieCategories.Text = ((_iptvAccount.Categories.Movie != null) ? _iptvAccount.Categories.Movie.Count() : 0).ToString("N0");
                lblSeriesCategories.Text = ((_iptvAccount.Categories.Series != null) ? _iptvAccount.Categories.Series.Count() : 0).ToString("N0");

                int catchupChannelCount = 0;
                foreach(var keyValuePair in _iptvAccount.AvailableChannels)
                {
                    var channel = keyValuePair.Value;
                    if(channel.TvArchiveDuration > 0)
                    {
                        catchupChannelCount++;
                    }
                }

                lblCatchupChannels.Text = catchupChannelCount.ToString();
                lblTotalChannels.Text = _iptvAccount.AvailableChannels.Count.ToString("N0");

                lblTsM3u.Text = TsM3uUrl;
                lblHlsM3u.Text = HlsM3uUrl;
                lblXmlEpg.Text = XmlEpgUrl;
                lblWatchOnline.Text = WatchOnlineUrl;

                lblTsM3u.Enabled = (lblTsM3u.Text != "Not Available");
                lblHlsM3u.Enabled = (lblHlsM3u.Text != "Not Available");

            }
        }

        private void PopulateAccountVariables()
        {
            _portalUrl = string.Empty;
            _userId = string.Empty;
            _password = string.Empty;
            if (cboInfoType.SelectedIndex == 0)
            {
                Uri myUri = new Uri(txtM3uUrl.Text);
                _portalUrl = myUri.Host;
                if(myUri.Port != 80)
                {
                    _portalUrl += ":" + myUri.Port.ToString();
                }
                _userId = HttpUtility.ParseQueryString(myUri.Query).Get("username");
                _password = HttpUtility.ParseQueryString(myUri.Query).Get("password");
            }
            else
            {
                if(!txtPortalUrl.Text.StartsWith("http"))
                {
                    txtPortalUrl.Text = string.Format("http://{0}", txtPortalUrl.Text);
                }
                Uri myUri = new Uri(txtPortalUrl.Text);
                _portalUrl = myUri.Host;
                if (myUri.Port != 80)
                {
                    _portalUrl = string.Format("{0}:{1}", _portalUrl, myUri.Port.ToString());
                }
                _userId = txtUserId.Text;
                _password = txtPassword.Text;
            }
        }

        private string ApiUrl
        {
            get
            {
                return string.Format("http://{0}/panel_api.php?username={1}&password={2}", _portalUrl, _userId, _password);
            }
        }
        private string TsM3uUrl
        {
            get
            {
                return _iptvAccount.UserInfo.AllowedOutputFormats.Contains("ts") ? string.Format("http://{0}/get.php?username={1}&&password={2}&&type=m3u_plus&&output=ts", _portalUrl, _userId, _password) : "Not Available";
            }
        }
        private string HlsM3uUrl
        {
            get
            {
                return _iptvAccount.UserInfo.AllowedOutputFormats.Contains("m3u8") ? string.Format("http://{0}/get.php?username={1}&&password={2}&&type=m3u_plus&&output=hls", _portalUrl, _userId, _password) : "Not Available";
            }
        }
        private string XmlEpgUrl
        {
            get
            {
                return string.Format("http://{0}/xmltv.php?username={1}&&password={2}", _portalUrl, _userId, _password);
            }
        }
        private string WatchOnlineUrl
        {
            get
            {
                return string.Format("http://{0}/client_area", _portalUrl);
            }
        }

        static DateTime EpochToDate(long? epochDate)
        {
            if (epochDate == null)
            {
                return DateTime.MaxValue;
            }
            DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            return result.ToLocalTime().AddSeconds((double)epochDate);
        }

        private void BtnCreateShortLinks_Click(object sender, EventArgs e)
        {
            lblTsM3uShort.Text = GetTinyUrl(lblTsM3u.Text);
            lblHlsM3uShort.Text = GetTinyUrl(lblHlsM3u.Text);
            lblXmlEpgShort.Text = GetTinyUrl(lblXmlEpg.Text);
        }

        private string GetTinyUrl(string url)
        {
            string text;
            try
            {
                var request = WebRequest.Create("http://tinyurl.com/api-create.php?url=" + url);
                var res = request.GetResponse();
                using (var reader = new StreamReader(res.GetResponseStream()))
                {
                    text = reader.ReadToEnd();
                }
            }
            catch
            {
                text = "Not Available";
            }
            return text;
        }

        private void CopyToClipboard(object sender, EventArgs e)
        {
            Clipboard.SetText(((LinkLabel)sender).Text);

            MessageBox.Show(string.Format("{0}\n\nhas been copied to the clipboard.", ((LinkLabel)sender).Text), "Copied to Clipboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
