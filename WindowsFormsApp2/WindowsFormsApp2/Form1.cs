using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Web;


namespace WindowsFormsApp2
{
    public partial class Gate_USB_BLE : Form
    {
        HttpClient client = new HttpClient();

        Product GetIdentifiersProduct = new Product
        {
            OutputAs = "Hex5"
        };


        // Метод, отправляющий POST-запрос на http://127.0.0.1:40011. 
        // Принимает аргументы: request - запрос, product - объект с телом запроса, 
        // label - поле, в которое нужно будет направить ответ.
        public async Task<Uri> SendProductAsync(string request, Product product, Label label)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                request, product);
            using (HttpContent content = response.Content)
            {
                string mycontent = await content.ReadAsStringAsync();

                mycontent = mycontent.Replace(",", ", \n");
                mycontent = mycontent.Replace("{", "");
                mycontent = mycontent.Replace("}", "");
                mycontent = mycontent.Replace("Enabled", "");
                mycontent = mycontent.Replace("\"", " ");
                mycontent = mycontent.Replace("true", " ДА ");
                mycontent = mycontent.Replace("false", " НЕТ ");





                label.Text = mycontent;
            }
            response.EnsureSuccessStatusCode();
            return response.Headers.Location;
        }

        public Gate_USB_BLE()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("http://localhost:40011/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            GetIdentifiers();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // Метод непрерывного запроса на получение номера принятого идентификатора
        async void GetIdentifiers()
        {
            try
            {
                while (true)
                {
                    HttpResponseMessage respons = await client.PostAsJsonAsync(
                        "GetIdentifiers", GetIdentifiersProduct);
                    using (HttpContent content = respons.Content)
                    {
                        string mycontent = "";
                        string info;
                        info = await content.ReadAsStringAsync();
                        if ((!info.Equals(mycontent)) && (info.IndexOf('}') > 20))
                        {
                            mycontent = info.Replace("{\"Identifiers\":[\"", "");
                            mycontent = mycontent.Replace("\"]}", "");
                            this.GetIdentifiersLabel.Text = mycontent;
                            this.GetIdentifiers2Label.Text = mycontent;
                            this.GetIdentifiers3Label.Text = mycontent;
                            this.GetIdentifiers4Label.Text = mycontent;
                        }
                    }
                }

            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
                MessageBox.Show("ERRORE");
            }
        }

        
        private async void GetVersionButton_Click_1(object sender, EventArgs e)
        {
            this.BLEBox.Visible = false;
            this.MifareBox.Visible = false;
            this.FSKBox.Visible = false;
            this.ASKBox.Visible = false;
            this.SetReaderTypeEndButton.Visible = false;
            this.OutputAsComboBox.Visible = false;
            this.ChangeFormatButton.Visible = false;

            try
            {
                Product product = new Product
                {

                };

                var url = await SendProductAsync("GetVersion", product, this.MainCommandLabel);
                

            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
                MessageBox.Show("ERRORE");
            }



        }

        
        private async void GetReaderTypeButton_Click(object sender, EventArgs e)
        {
            this.BLEBox.Visible = false;
            this.MifareBox.Visible = false;
            this.FSKBox.Visible = false;
            this.ASKBox.Visible = false;
            this.SetReaderTypeEndButton.Visible = false;
            this.OutputAsComboBox.Visible = false;
            this.ChangeFormatButton.Visible = false;
            try
            {
                // Create a new product
                Product product = new Product
                {

                };

                var url = await SendProductAsync("GetReaderType", product, this.MainCommandLabel );
                //Console.WriteLine($"Created at {url}");

            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
                MessageBox.Show("ERRORE");
            }

        }


        private async void GetQuantityButton_Click(object sender, EventArgs e)
        {
            this.BLEBox.Visible = false;
            this.MifareBox.Visible = false;
            this.FSKBox.Visible = false;
            this.ASKBox.Visible = false;
            this.SetReaderTypeEndButton.Visible = false;
            try
            {
                
                Product product = new Product
                {

                };

                var url = await SendProductAsync("GetQuantity", product, this.MainCommandLabel);
                

            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
                MessageBox.Show("ERRORE");
            }
        }

        private async void SetReaderTypeEndButton_Click(object sender, EventArgs e)
        {
            this.BLEBox.Visible = false;
            this.MifareBox.Visible = false;
            this.FSKBox.Visible = false;
            this.ASKBox.Visible = false;
            this.SetReaderTypeEndButton.Visible = false;
            try
            {

                Product product = new Product
                {
                    BLEEnabled = this.BLEBox.Checked,
                    MifareEnabled = this.MifareBox.Checked,
                    FSKEnabled = this.FSKBox.Checked,
                    ASKEnabled = this.ASKBox.Checked

                };

                var url = await SendProductAsync("SetReaderType", product, this.MainCommandLabel);


            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
                MessageBox.Show("ERRORE");
            }

        }

        private  void SetReaderTypeBeginButton_Click(object sender, EventArgs e)
        {
            this.BLEBox.Visible = true;
            this.MifareBox.Visible = true;
            this.FSKBox.Visible = true;
            this.ASKBox.Visible = true;
            this.SetReaderTypeEndButton.Visible = true;
            this.OutputAsComboBox.Visible = false;
            this.ChangeFormatButton.Visible = false;

        }

        private void SecureMobileIDsButton_Click(object sender, EventArgs e)
        {
            this.GetEncryptedMifareIDSendButton.Visible = false;
            this.GetEncryptedMifareIDListBox.Visible = false;

            this.SecureMobileIDsOFFButton.Visible = true;
            this.SecureMobileIDsONButton.Visible = true;

            this.SecureMifareIDsOFFButton.Visible = false;
            this.SecureMifareIDsONButton.Visible = false;
            this.SecureMifareIDsPasswordTextBox.Visible = false;
            this.SecureMifareIDsSendButton.Visible = false;
            this.SecureMifareIDsCodeButton.Visible = false;
            this.SecureMifareIDsCodeTextBox.Visible = false;
        }

        private async void IsEncryptedButton_Click(object sender, EventArgs e)
        {
            this.GetEncryptedMifareIDSendButton.Visible = false;
            this.GetEncryptedMifareIDListBox.Visible = false;

            try
            {
                Product product = new Product
                {

                };

                // TODO: Решить проблему с запросом isEncrypted
                var url = await SendProductAsync("isEncrypted", product, this.EncryptionLabel);
                

            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
                MessageBox.Show("ERRORE");
            }
            this.SecureMobileIDsOFFButton.Visible = false;
            this.SecureMobileIDsONButton.Visible = false;
            this.SecureMobileIDsONTextBox.Visible = false;
            this.SecureMobileIDsONSendButton.Visible = false;

            this.SecureMifareIDsOFFButton.Visible = false;
            this.SecureMifareIDsONButton.Visible = false;
            this.SecureMifareIDsPasswordTextBox.Visible = false;
            this.SecureMifareIDsSendButton.Visible = false;
            this.SecureMifareIDsCodeButton.Visible = false;
            this.SecureMifareIDsCodeTextBox.Visible = false;

            
        }

        private void SecureMifareIDsButton_Click(object sender, EventArgs e)
        {
            this.GetEncryptedMifareIDSendButton.Visible = false;
            this.GetEncryptedMifareIDListBox.Visible = false;

            this.SecureMobileIDsOFFButton.Visible = false;
            this.SecureMobileIDsONButton.Visible = false;
            this.SecureMobileIDsONTextBox.Visible = false;
            this.SecureMobileIDsONSendButton.Visible = false;


            this.SecureMifareIDsOFFButton.Visible = true;
            this.SecureMifareIDsONButton.Visible = true;
        }

        private void GetEncryptedMifareIDButton_Click(object sender, EventArgs e)
        {
            this.SecureMobileIDsOFFButton.Visible = false;
            this.SecureMobileIDsONButton.Visible = false;
            this.SecureMobileIDsONTextBox.Visible = false;
            this.SecureMobileIDsONSendButton.Visible = false;


            this.SecureMifareIDsOFFButton.Visible = false;
            this.SecureMifareIDsONButton.Visible = false;
            this.SecureMifareIDsPasswordTextBox.Visible = false;
            this.SecureMifareIDsSendButton.Visible = false;
            this.SecureMifareIDsCodeButton.Visible = false;
            this.SecureMifareIDsCodeTextBox.Visible = false;

            this.GetEncryptedMifareIDSendButton.Visible = true;
            this.GetEncryptedMifareIDListBox.Visible = true;


        }

        private void SecureMobileIDsONButton_Click(object sender, EventArgs e)
        {
            
            this.SecureMobileIDsONTextBox.Visible = true;
            this.SecureMobileIDsONSendButton.Visible = true;
        }

        private async void SecureMobileIDsONSendButton_Click(object sender, EventArgs e)
        {
            
            
            if (IsTheCodeCorrect(this.SecureMobileIDsONTextBox.Text, 12))
            {
                this.SecureMobileIDsOFFButton.Visible = false;
                this.SecureMobileIDsONButton.Visible = false;
                this.SecureMobileIDsONTextBox.Visible = false;
                this.SecureMobileIDsONSendButton.Visible = false;
                try
                {
                    Product product = new Product
                    {
                        MobilePassword = this.SecureMobileIDsONTextBox.Text
                    };

                    // TODO: Решить проблему в отправкой пароля
                    var url = await SendProductAsync("SecureMobileIDs", product, this.EncryptionLabel);
                    

                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee.Message);
                    MessageBox.Show("ERRORE");
                }

                //после всех действий очистка поля пароля
                this.SecureMobileIDsONTextBox.Clear();

            }
            else
            {
                MessageBox.Show("НЕКОРРЕКТНЫЙ ПАРОЛЬ");
                this.SecureMobileIDsONTextBox.Clear();
            }

        }

        private bool IsTheCodeCorrect (string code, int type)
        {
            if (!string.IsNullOrWhiteSpace(code))
            {
                char[] codechars = code.ToCharArray();

                if (codechars.Length!=type)
                {
                    return false;
                    
                }
                else
                {
                    for (int i = 0; i < codechars.Length; i++)
                    {
                        if ((!char.IsNumber(code[i])) && (!code[i].Equals('A')) && (!code[i].Equals('B')) && (!code[i].Equals('C')) && (!code[i].Equals('D')) && (!code[i].Equals('E')) && (!code[i].Equals('F')))
                        {
                            return false;
                        }
                    }
                }


            return true;
            }
            else
            {
                return false;
            }
        }

        private async void SecureMobileIDsOFFButton_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product
                {
                    MobilePassword = ""
                };

                var url = await SendProductAsync("SecureMobileIDs", product, this.EncryptionLabel);


            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
                MessageBox.Show("ERRORE");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void SecureMifareIDsOFFButton_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product
                {
                    MobilePassword = ""
                };

                var url = await SendProductAsync("SecureMifareIDs", product, this.EncryptionLabel);


            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
                MessageBox.Show("ERRORE");
            }
        }

        private void SecureMifareIDsONButton_Click(object sender, EventArgs e)
        {

            this.SecureMifareIDsPasswordTextBox.Visible = true;
            this.SecureMifareIDsSendButton.Visible = true;
            this.SecureMifareIDsCodeButton.Visible = true;
        }

        private void SecureMifareIDsCodeButton_Click(object sender, EventArgs e)
        {
            this.SecureMifareIDsCodeTextBox.Visible = true;
        }

        private void GetEncryptedMifareIDListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void GetEncryptedMifareIDSendButton_Click(object sender, EventArgs e)
        {
            if (GetEncryptedMifareIDListBox.SelectedIndex!=-1)
            {
                try
                {
                    Product product = new Product
                    {
                        OutputAs = GetEncryptedMifareIDListBox.SelectedItem.ToString()
                    };

                    // TODO :: Не проверялось
                    var url = await SendProductAsync("GetEncryptedMifareID", product, this.EncryptionLabel);
                    MessageBox.Show("Выпущена карта с форматом " + product.OutputAs);

                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee.Message);
                    MessageBox.Show("ERRORE");
                }
            }
            else
            {
                MessageBox.Show("Выберите формат вывода");
            }
        }

        private async void SecureMifareIDsSendButton_Click(object sender, EventArgs e)
        {
            if (IsTheCodeCorrect(this.SecureMifareIDsPasswordTextBox.Text, 12))
            {
                if (string.IsNullOrEmpty(SecureMifareIDsCodeTextBox.Text))
                {
                    //без кода
                    
                    try
                    {
                        Product product = new Product
                        {
                            MifarePassword = SecureMifareIDsPasswordTextBox.Text
                        };

                        var url = await SendProductAsync("SecureMifareID", product, this.MainCommandLabel);


                    }
                    catch (Exception ee)
                    {
                        Console.WriteLine(ee.Message);
                        MessageBox.Show("ERRORE");
                    }


                }
                else
                {
                    //с кодом
                    if (IsTheCodeCorrect(SecureMifareIDsCodeTextBox.Text, 10))
                    {
                        try
                        {
                            Product product = new Product
                            {
                                MifarePassword = SecureMifareIDsPasswordTextBox.Text,
                                StartingCode = SecureMifareIDsCodeTextBox.Text
                            };

                            var url = await SendProductAsync("SecureMifareID", product, this.MainCommandLabel);


                        }
                        catch (Exception ee)
                        {
                            Console.WriteLine(ee.Message);
                            MessageBox.Show("ERRORE");
                        }
                    }
                    else
                    {
                        MessageBox.Show("НЕКОРРЕКТНЫЙ КОД");
                    }
                }
            }
            else
            {
                MessageBox.Show("НЕКОРРЕКТНЫЙ ПАРОЛЬ");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //проверка корректности IP
        public bool isSMTPServerCorrect(string input)
        {
            string[] strArr = input.Split('.');
            int[] intArr = new int[strArr.Length];
            if (intArr.Length != 4)
            {
                return false;

            }
            try
            {
                for (int i = 0; i < strArr.Length; i++)
                {
                    intArr[i] = int.Parse(strArr[i]);

                }
                return true;


            }
            catch (Exception e)
            {
                return false;

            }

        }

        //проверка корректности электронной почты
        public bool isSMTPSendFromCorrect(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(input);
                return addr.Address == input;
            }
            catch (Exception e)
            {
                return false;
            }


        }

        private async void Page5SecureMifareIDsButton_Click(object sender, EventArgs e)
        {
            if(!this.isSMTPServerCorrect(SMTPServerTextBox.Text))
            {
                MessageBox.Show("НЕКОРРЕКТНЫЙ АДРЕС SMTP-СЕРВЕРА");
            }
            else
            {
                try
                {
                    int.Parse(SMTPPortTextBox.Text);

                    if (!this.isSMTPUserOrSMTPPasswordCorrect(SMTPUserTextBox.Text))
                    {
                        MessageBox.Show("НЕКОРРЕКТНОЕ ИМЯ ПОЛЬЗОВАТЕЛЯ");
                    }

                    else if (!this.isSMTPUserOrSMTPPasswordCorrect(SMTPPasswordTextBox.Text))
                    {
                        MessageBox.Show("НЕКОРРЕКТНЫЙ ПАРОЛЬ");
                    }

                    else if (!isSMTPSendFromCorrect(SMTPSendFromTextBox.Text))
                    {
                        MessageBox.Show("НЕКОРРЕКТНАЯ ЭЛЕКТРОННАЯ ПОЧТА");
                    }
                    else
                    {
                        MessageBox.Show("ДАННЫЕ ПРИНЯТЫ");
                        try
                        {
                            Product product = new Product
                            {
                                SmtpServerEnabled = SmtpServerEnabledCheckBox.Checked,
                                SMTPEncrypted = SMTPEncryptedCheckBox.Checked,
                                SMTPServer = SMTPServerTextBox.Text,
                                SMTPPort = int.Parse(SMTPPortTextBox.Text),
                                SMTPUser = SMTPUserTextBox.Text,
                                SMTPPassword = SMTPPasswordTextBox.Text,
                                SMTPSendFrom = SMTPSendFromTextBox.Text


                            };

                            var url = await SendProductAsync("SecureMifareIDs", product, this.SecureMifareIDsLabel);


                        }
                        catch (Exception ee)
                        {
                            Console.WriteLine(ee.Message);
                            MessageBox.Show("ERRORE");
                        }
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show("НЕКОРРЕКТНЫЙ ПОРТ");
                }
            }
        }

        public bool isSMTPUserOrSMTPPasswordCorrect(string input)
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                char[] codechars = input.ToCharArray();

                    for (int i = 0; i < codechars.Length; i++)
                    {
                    if ((!char.IsDigit(codechars[i])) && (!((codechars[i] >= '\u0041') && (codechars[i] <= '\u005A'))) && (!((codechars[i] >= '\u0061') && (codechars[i] <= '\u007A'))))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private void IssueRemoteIdentifierUserCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IssueRemoteIdentifierUserCodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void IssueRemoteIdentifierButton_Click(object sender, EventArgs e)
        {
            IssueRemoteIdentifierUrlLabel.Visible = true;
            IssueRemoteIdentifierUrlTextBox.Visible = true;
            IssueRemoteIdentifierUserCodeLabel.Visible = true;
            IssueRemoteIdentifierUserCodeTextBox.Visible = true;
            IssueRemoteIdentifierCheckBox.Visible = true;
            IssueRemoteIdentifierEmailTextBox.Visible = true;
            IssueRemoteIdentifierFormatCheckBox.Visible = true;
            IssueRemoteIdentifierFormatListBox.Visible = true;
            IssueRemoteIdentifierSendButton.Visible = true;

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            IssueRemoteIdentifierUrlLabel.Visible = false;
            IssueRemoteIdentifierUrlTextBox.Visible = false;
            IssueRemoteIdentifierUserCodeLabel.Visible = false;
            IssueRemoteIdentifierUserCodeTextBox.Visible = false;
            IssueRemoteIdentifierCheckBox.Visible = false;
            IssueRemoteIdentifierEmailTextBox.Visible = false;
            IssueRemoteIdentifierFormatCheckBox.Visible = false;
            IssueRemoteIdentifierFormatListBox.Visible = false;
            IssueRemoteIdentifierSendButton.Visible = false;

            try
            {

                Product product = new Product
                {

                };

                var url = await SendProductAsync("GetQuantity", product, this.MobileIdentifiersLabel);
                


            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
                MessageBox.Show("ERRORE");
            }
        }

        private void OutputAsButton_Click(object sender, EventArgs e)
        {
            this.BLEBox.Visible = false;
            this.MifareBox.Visible = false;
            this.FSKBox.Visible = false;
            this.ASKBox.Visible = false;
            this.SetReaderTypeEndButton.Visible = false;
            this.OutputAsComboBox.Visible = true;
            this.ChangeFormatButton.Visible = true;


        }

        private void ChangeFormatButton_Click(object sender, EventArgs e)
        {
            if (!OutputAsComboBox.Text.Equals(""))
            {
                GetIdentifiersProduct.OutputAs = OutputAsComboBox.Text;

            }
                            this.OutputAsComboBox.Visible = false;
                this.ChangeFormatButton.Visible = false;

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private async void IssueRemoteIdentifierSendButton_Click(object sender, EventArgs e)
        {
                Product product = new Product
                {
                    UserCode = HttpUtility.UrlDecode(this.IssueRemoteIdentifierUserCodeTextBox.Text),
                    SendEmail = this.IssueRemoteIdentifierCheckBox.Checked
                };

                if (IssueRemoteIdentifierCheckBox.Checked)
                {
                    if (!isSMTPSendFromCorrect(IssueRemoteIdentifierEmailTextBox.Text))
                    {
                        MessageBox.Show("НЕКОРРЕКТНАЯ ЭЛЕКТРОННАЯ ПОЧТА");
                    }
                    else
                    {
                        product.Email = IssueRemoteIdentifierEmailTextBox.Text;
                    }
                    
                }

                if (IssueRemoteIdentifierFormatCheckBox.Checked)
                {

                try
                {
                    product.OutputAs = IssueRemoteIdentifierFormatListBox.SelectedItem.ToString();
                }
                catch (NullReferenceException ee)
                {
                    MessageBox.Show("ВЫБЕРИТЕ ТИП ФОРМАТА ИЛИ СНИМИТЕ СООТВЕТСТВУЮЩУЮ ГАЛОЧКУ");
                }

                }

            try
            {

                var url = await SendProductAsync("IssueRemoteIdentifier", product, this.MobileIdentifiersLabel);


            }
            catch (Exception ee)
            {
                MessageBox.Show("ERRORE");
            }






        }
    }



    // Класс, объекты которого будут формировать тело запроса
    public class Product
    {
        public bool BLEEnabled { get; set; }
        public bool MifareEnabled { get; set; }
        public bool FSKEnabled { get; set; }
        public bool ASKEnabled { get; set; }
        public string OutputAs { get; set; }

        public string UserCode { get; set; }

        public bool SendEmail { get; set; }
        public string Email { get; set; }
        public string MobilePassword { get; set; }
        public string MifarePassword { get; set; }
        public string StartingCode { get; set; }
        public bool SmtpServerEnabled { get; set; }
        public bool SMTPEncrypted { get; set; }
        public string SMTPServer { get; set; }
        public int SMTPPort { get; set; }
        public string SMTPUser { get; set; }
        public string SMTPPassword { get; set; }

        public string SMTPSendFrom { get; set; }



    }
}
