using MinerStatusChecker.Models;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace MinerStatusChecker
{
    class Program
    {
        private static string PanelID { get; set; }
        private static double HashEndurance { get; set; }
        private static string SmtpEmail { get; set; }
        private static string SmtpPasscode { get; set; }
        private static string EmailToNotify { get; set; }

        private static PanelDetails panel;

        static void Main(string[] args)
        {
            PanelID = args[0];
            HashEndurance = double.Parse(args[1]);
            SmtpEmail = args[2];
            SmtpPasscode = args[3];
            EmailToNotify = args[4];

            GetPanelDetails();

            bool hasIssue = false;
            if (GetPanelIssue() || GetRigIssue())
            {
                hasIssue = true;
            }

            if (hasIssue)
            {
                SendNotificationEmail();
            }
        }

        private static void GetPanelDetails()
        {
            string requestUri = $"http://{PanelID}.ethosdistro.com/?json=yes";
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(requestUri);
            webRequest.Method = @"GET";
            webRequest.Accept = @"application/json";
            using (HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse())
            {
                using (StreamReader reader = new StreamReader(webResponse.GetResponseStream()))
                {
                    panel = JsonConvert.DeserializeObject<PanelDetails>(reader.ReadToEnd());
                }
            }
        }

        private static bool GetPanelIssue()
        {
            bool hasIssue = false;
            if (panel.AliveGpus < panel.TotalGpus || panel.AliveRigs < panel.TotalRigs)
            {
                hasIssue = true;
            }
            return hasIssue;
        }

        private static bool GetRigIssue()
        {
            bool hasIssue = false;
            foreach (RigDetails rig in panel.Rigs.Values)
            {
                if (rig.Condition != "mining" || GetHashRateIssue(rig.MinerHashes))
                {
                    hasIssue = true;
                    break;
                }
            }
            return hasIssue;
        }

        private static bool GetHashRateIssue(string hashes)
        {
            bool hasIssue = false;
            string[] hashesRate = hashes.Split(" ");
            foreach (string hash in hashesRate)
            {
                if (double.Parse(hash) <= HashEndurance)
                {
                    hasIssue = true;
                    break;
                }
            }
            return hasIssue;
        }

        private static void SendNotificationEmail()
        {
            using (SmtpClient client = new SmtpClient())
            {
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(SmtpEmail, SmtpPasscode);
                client.Port = 587;
                client.Host = @"smtp.gmail.com";

                MailMessage email = new MailMessage();
                email.From = new MailAddress(SmtpEmail);
                email.Subject = @"Your rig has some issue";
                email.To.Add(new MailAddress(EmailToNotify));
                email.IsBodyHtml = false;
                email.Body = $"Check here: http://{PanelID}.ethosdistro.com";

                client.Send(email);
            }
        }
    }
}
