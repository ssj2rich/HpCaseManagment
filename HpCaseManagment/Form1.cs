using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace HpCaseManagment
{
    public partial class Form1 : Form
    {
        public bool userChanged = false;
        public bool emailLayoutChanged = false;
        public List<User> currentUsers = new List<User>();
        public List<Case> cases = new List<Case>();
        public Form1()
        {
            InitializeComponent();

            //load users from users file
            //load data from excel file
            //save data to users file
            //generate statistics file ? 
            //send emails
            lbCases.Visible = false;
            lblSummery.Visible = false;
            btnRunProcess_Click(null, null);
        }

        private void lbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbUsers.SelectedIndex >= 0)
            {
                if (userChanged)
                {
                    PopUpMsg popup = new PopUpMsg();
                    DialogResult res = popup.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        currentUsers = loadUsers();
                        tbEmail.Text = currentUsers[lbUsers.SelectedIndex].email;
                        lblUserName.Text = currentUsers[lbUsers.SelectedIndex].userName;
                        cbSendEmail.Checked = currentUsers[lbUsers.SelectedIndex].isActive;
                        cbGroupEmails.Checked = currentUsers[lbUsers.SelectedIndex].isGrouppingEmails;
                        lblTeam.Text = currentUsers[lbUsers.SelectedIndex].team;
                        userChanged = false;
                    }
                    popup.Dispose();
                }
                else
                {
                    currentUsers = loadUsers();
                    tbEmail.Text = currentUsers[lbUsers.SelectedIndex].email;
                    lblUserName.Text = currentUsers[lbUsers.SelectedIndex].userName;
                    cbSendEmail.Checked = currentUsers[lbUsers.SelectedIndex].isActive;
                    cbGroupEmails.Checked = currentUsers[lbUsers.SelectedIndex].isGrouppingEmails;
                    lblTeam.Text = currentUsers[lbUsers.SelectedIndex].team;
                    userChanged = false;
                }
            }

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox1, "Settings");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //load settings
            if (emailLayoutChanged)
            {
                PopUpMsg popup = new PopUpMsg();
                DialogResult res = popup.ShowDialog();
                if (res != DialogResult.OK)
                {
                    return;
                }
            }
            emailLayoutChanged = false;
            loadEmailLayouts();
            pnlEmailLayout.Visible = false;
            pnlUserManagment.Visible = false;
            pnlSettings.Visible = true;
            pnlProcessRunning.Visible = false;
        }


        private void btnUserManagment_Click(object sender, EventArgs e)
        {
            if (emailLayoutChanged)
            {
                PopUpMsg popup = new PopUpMsg();
                DialogResult res = popup.ShowDialog();
                if (res != DialogResult.OK)
                {
                    return;
                }
            }
            emailLayoutChanged = false;
            loadEmailLayouts();
            pnlEmailLayout.Visible = false;
            pnlSettings.Visible = false;
            pnlUserManagment.Visible = true;
            pnlProcessRunning.Visible = false;
            userChanged = false;

            currentUsers = loadUsers();

            foreach (var item in currentUsers)
            {
                lbUsers.Items.Add(item.userName);
            }
        }

        private void btnRunProcess_Click(object sender, EventArgs e)
        {
            if (emailLayoutChanged)
            {
                PopUpMsg popup = new PopUpMsg();
                DialogResult res = popup.ShowDialog();
                if (res != DialogResult.OK)
                {
                    return;
                }
            }
            emailLayoutChanged = false;
            loadEmailLayouts();
            pnlEmailLayout.Visible = false;
            pnlSettings.Visible = false;
            pnlUserManagment.Visible = false;
            pnlProcessRunning.Visible = true;

            currentUsers = loadUsers();
            cases = new List<Case>();

            DataTable dt = ReadExcel(tbExcelFileLocation.Text + "\\" + tbExcelFileName.Text, ".xls");
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow singleRow in dt.Rows)
                {
                    string caseId = singleRow["Case Id"].ToString();
                    string userName = singleRow["Event Owner"].ToString();
                    string eventAge = singleRow["Event Age"].ToString();
                    string userTeam = singleRow["Maincase Ow Work Group"].ToString();
                    string daysSinceLastActivity = singleRow["Days Since Last Activity Event"].ToString();
                    Case c1 = new Case();
                    User caseUser = new User();
                    User savedUser = currentUsers.Where(d => d.userName == userName).FirstOrDefault();
                    if (userTeam.Contains("ILG_SC GSC EUO P IPG Qualifiers") || userTeam.Contains("ILP_SC GSC EUO P PSG Qualifiers"))
                    {
                        if (savedUser != null)
                        {
                            c1.user = savedUser;
                        }
                        else
                        {

                            caseUser.team = userTeam;
                            caseUser.userName = userName;
                            c1.user = caseUser;
                        }
                        c1.caseId = caseId;
                        c1.caseAge = eventAge;
                        c1.daysSinceLastActivity = daysSinceLastActivity;


                        c1.caseId = caseId;
                        c1.caseAge = eventAge;
                        c1.daysSinceLastActivity = daysSinceLastActivity;
                        cases.Add(c1);


                    }
                }

                lblSummery.Text = "Found " + cases.Count + " Cases for " + cases.GroupBy(d => d.user.userName).Count() + " Users \n Of which " + cases.Where(ue => string.IsNullOrEmpty(ue.user.email)).GroupBy(d => d.user.userName).Count() + " are new users";
                foreach (var item in cases)
                {
                    lbCases.Items.Add("Case: " + item.caseId + " user: " + item.user.userName);

                    if (!currentUsers.Any(d => d.userName.Equals(item.user.userName)))
                    {
                        currentUsers.Add(item.user);

                    }


                }
            }
            saveUsers(currentUsers);
            pictureBox2.Visible = false;
            lbCases.Visible = true;
            lblSummery.Visible = true;
        }

        public List<User> loadUsers()
        {
            userChanged = false;
            List<User> currentUsers = new List<User>();
            if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\savedUsers.ini"))
            {
                //we got a users file, lets get the data
                StreamReader sr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\savedUsers.ini");
                string jsonData = sr.ReadToEnd();
                sr.Close();
                currentUsers = JsonConvert.DeserializeObject<List<User>>(jsonData);
            }

            return currentUsers;
        }

        public void saveUsers(List<User> usersToSave)
        {
            string res = JsonConvert.SerializeObject(usersToSave);
            StreamWriter sw = new StreamWriter(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\savedUsers.ini");
            sw.WriteLine(res);
            sw.Close();
        }

        public DataTable ReadExcel(string fileName, string fileExt)
        {
            string conn = string.Empty;
            DataTable dtexcel = new DataTable();
            if (fileExt.CompareTo(".xls") == 0)
                conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';"; //for below excel 2007  
            else
                conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=NO';"; //for above excel 2007  
            using (OleDbConnection con = new OleDbConnection(conn))
            {
                try
                {
                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [EMEA_Backlog_coded$]", con); //here we read data from sheet1  
                    oleAdpt.Fill(dtexcel); //fill excel data into dataTable  
                }
                catch { }
            }
            return dtexcel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            userChanged = false;
            List<User> currentUsers = loadUsers();

            User user = currentUsers.Where(d => d.userName == lblUserName.Text).FirstOrDefault();

            if (user != null)
            {
                user.email = tbEmail.Text;
                user.isActive = cbSendEmail.Checked;
                user.isGrouppingEmails = cbGroupEmails.Checked;
            }
            saveUsers(currentUsers);

        }

        private void tbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            userChanged = true;
        }

        private void cbSendEmail_CheckedChanged(object sender, EventArgs e)
        {
            userChanged = true;
        }

        private void cbGroupEmails_CheckedChanged(object sender, EventArgs e)
        {
            userChanged = true;
        }

        private void chCheckCase_CheckedChanged(object sender, EventArgs e)
        {
            userChanged = true;
        }

        public void sendEmailSingleTemplate(string to, string body)
        {
            var fromAddress = new MailAddress(System.Configuration.ConfigurationSettings.AppSettings["fromEmail"].ToString(), System.Configuration.ConfigurationSettings.AppSettings["fromEmailName"].ToString());
            MailAddress toAddress = new MailAddress(to);
            string fromPassword = System.Configuration.ConfigurationSettings.AppSettings["FromPassword"];

            string subject = System.Configuration.ConfigurationSettings.AppSettings["singleEmailFormatSubject"];

            var smtp = new SmtpClient
            {
                Host = System.Configuration.ConfigurationSettings.AppSettings["SmptIp"],
                Port = int.Parse(System.Configuration.ConfigurationSettings.AppSettings["SmptPort"]),
                EnableSsl = bool.Parse(System.Configuration.ConfigurationSettings.AppSettings["isSsl"]),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }

        private void btnSendEmails_Click(object sender, EventArgs e)
        {
            PopUpMsgEmails popup = new PopUpMsgEmails();
            DialogResult res = popup.ShowDialog();
            if (res == DialogResult.OK)
            {
                //send emails
                if (Convert.ToBoolean(System.Configuration.ConfigurationSettings.AppSettings["isGmail"]))
                {
                    foreach (var singleUser in currentUsers)
                    {
                        if (!singleUser.isActive)
                        {
                            break;
                        }

                        if (singleUser.isGrouppingEmails)
                        {
                            string body = rtbGroupEmailFormat.Text;

                            string repeatingPart = body.Substring(body.IndexOf("#caseRepeaterStart#") + "#caseRepeaterStart#".Length, body.IndexOf("#caseRepeaterEnd#") - (body.IndexOf("#caseRepeaterStart#") + "#caseRepeaterStart#".Length));

                            body = body.Replace("#userName#", singleUser.userName);
                            body = body.Replace("#userEmail#", singleUser.email);
                            body = body.Replace("#userTeam#", singleUser.team);

                            //string repeatingPart = body.Substring(body.IndexOf("#caseRepeaterStart#") + "#caseRepeaterStart#".Length, body.IndexOf("#caseRepeaterEnd#") - (body.IndexOf("#caseRepeaterStart#") + "#caseRepeaterStart#".Length));

                            string newBody = body.Substring(0, body.IndexOf("#caseRepeaterStart#"));
                            List<Case> userCases = cases.Where(d => d.user.userName == singleUser.userName).ToList();
                            foreach (var singleCase in userCases)
                            {
                                if (singleCase.user.email == singleUser.email)
                                {
                                    string repeatingPart1 = repeatingPart.Replace("#userName#", singleUser.userName);
                                    repeatingPart1 = repeatingPart1.Replace("#userEmail#", singleUser.email);
                                    repeatingPart1 = repeatingPart1.Replace("#caseId#", singleCase.caseId);
                                    repeatingPart1 = repeatingPart1.Replace("#userTeam#", singleUser.team);
                                    repeatingPart1 = repeatingPart1.Replace("#caseAge#", singleCase.caseAge);
                                    repeatingPart1 = repeatingPart1.Replace("#DaysSinceLastActivity#", singleCase.daysSinceLastActivity);
                                    newBody += repeatingPart1;
                                }
                            }
                            newBody += body.Substring(body.IndexOf("#caseRepeaterEnd#") + "#caseRepeaterEnd#".Length);
                            body = newBody;

                            sendEmailSingleTemplate(singleUser.email, body);
                            break;
                        }
                        else
                        {
                            foreach (var singleCase in cases)
                            {
                                string body = rtbEmailSingleFormat.Text;
                                body = body.Replace("#userName#", singleUser.userName);
                                body = body.Replace("#userEmail#", singleUser.email);
                                body = body.Replace("#caseId#", singleCase.caseId);
                                body = body.Replace("#userTeam#", singleUser.team);
                                body = body.Replace("#caseAge#", singleCase.caseAge);
                                body = body.Replace("#DaysSinceLastActivity#", singleCase.daysSinceLastActivity);
                                sendEmailSingleTemplate(singleUser.email, body);
                                break;

                            }
                        }
                        break;
                    }

                }

            }
            popup.Dispose();
        }

        private void btnEmailLayout_Click(object sender, EventArgs e)
        {
            pnlSettings.Visible = false;
            pnlUserManagment.Visible = false;
            pnlProcessRunning.Visible = false;
            pnlEmailLayout.Visible = true;
            userChanged = false;
            loadEmailLayouts();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void copyToClip_Click(object sender, EventArgs e)
        {
            if ((((Label)sender).Name == "lblRepeat" || ((Label)sender).Name == "lblRepeatEnd") && this.ActiveControl.Name == "rtbEmailSingleFormat")
            {
                MessageBox.Show("You cant add a case repeater to the single case email layout", "", MessageBoxButtons.OK);
                return;

            }

            if ((((Label)sender).Name == "lblRepeat" || ((Label)sender).Name == "lblRepeatEnd") && this.ActiveControl.Name == "rtbGroupEmailFormat")
            {
                if (rtbGroupEmailFormat.Text.Contains("#caseRepeaterStart#") && ((Label)sender).Name == "lblRepeat")
                {
                    MessageBox.Show("You can only add 1 repeater start to the layout", "", MessageBoxButtons.OK);
                    return;
                }

                if (rtbGroupEmailFormat.Text.Contains("#caseRepeaterEnd#") && ((Label)sender).Name == "lblRepeatEnd")
                {
                    MessageBox.Show("You can only add 1 repeater end to the layout", "", MessageBoxButtons.OK);
                    return;
                }
            }

            System.Windows.Forms.Clipboard.SetText(((Label)sender).Text);
            if (this.ActiveControl.Name == "rtbEmailSingleFormat")
            {

                var selectionIndex = rtbEmailSingleFormat.SelectionStart;
                rtbEmailSingleFormat.Text = rtbEmailSingleFormat.Text.Insert(selectionIndex, ((Label)sender).Text);
                rtbEmailSingleFormat.SelectionStart = selectionIndex + ((Label)sender).Text.Length;
            }
            else if (this.ActiveControl.Name == "rtbGroupEmailFormat")
            {
                var selectionIndex = rtbGroupEmailFormat.SelectionStart;
                rtbGroupEmailFormat.Text = rtbGroupEmailFormat.Text.Insert(selectionIndex, ((Label)sender).Text);
                rtbGroupEmailFormat.SelectionStart = selectionIndex + ((Label)sender).Text.Length;
            }

        }

        private void toolTipPH_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip((Label)sender, "Press To Copy Text");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveEmails_Click(object sender, EventArgs e)
        {
            saveEmailLayouts();

        }

        public void loadEmailLayouts()
        {
            emailLayoutChanged = false;

            if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\savedSingleLayout.ini"))
            {
                //we got a users file, lets get the data
                StreamReader sr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\savedSingleLayout.ini");
                string jsonData = sr.ReadToEnd();
                rtbEmailSingleFormat.Text = jsonData;
                sr.Close();
            }

            if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\savedGroupLayout.ini"))
            {
                //we got a users file, lets get the data
                StreamReader sr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\savedGroupLayout.ini");
                string jsonData = sr.ReadToEnd();
                rtbGroupEmailFormat.Text = jsonData;
                sr.Close();
            }
            emailLayoutChanged = false;
        }

        public void saveEmailLayouts()
        {
            emailLayoutChanged = false;
            StreamWriter sw = new StreamWriter(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\savedSingleLayout.ini");
            sw.WriteLine(rtbEmailSingleFormat.Text);
            sw.Close();

            sw = new StreamWriter(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\savedGroupLayout.ini");
            sw.WriteLine(rtbGroupEmailFormat.Text);
            sw.Close();
            emailLayoutChanged = false;
        }
        private void rtbEmailSingleFormat_TextChanged(object sender, EventArgs e)
        {
            emailLayoutChanged = true;
        }

        private void cbAllActive_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAllActive.Checked)
            {
                foreach (var item in currentUsers)
                {
                    if (!string.IsNullOrEmpty(item.email))
                    {
                        item.isActive = true;
                    }
                }

            }
            else
            {
                foreach (var item in currentUsers)
                {
                    item.isActive = false;
                }
            }
            saveUsers(currentUsers);

            lbUsers_SelectedIndexChanged(null, null);
        }

        private void cbAllGroup_CheckedChanged(object sender, EventArgs e)
        {

            if (cbAllGroup.Checked)
            {
                foreach (var item in currentUsers)
                {
                    item.isGrouppingEmails = true;
                }

            }
            else
            {
                foreach (var item in currentUsers)
                {
                    item.isGrouppingEmails = false;
                }
            }
            saveUsers(currentUsers);

            lbUsers_SelectedIndexChanged(null, null);

        }
    }
}
