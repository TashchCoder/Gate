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

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        HttpClient client = new HttpClient();

        public async Task<Uri> CreateProductAsync(Product product, string request)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                request, product);
            using (HttpContent content = response.Content)
            {
                string mycontent = await content.ReadAsStringAsync();
                mycontent=mycontent.Replace(",",", \n");
                this.MainInfoLabel.Text = mycontent;
            }


            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }


        public Form1()
        {
            InitializeComponent();
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://localhost:40011/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            GetIdentifiers();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void GetVersionButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new product
                Product product = new Product
                {

                };

                var url = await CreateProductAsync(product, "GetVersion");
                //Console.WriteLine($"Created at {url}");

            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
                MessageBox.Show("ERRORE");
            }
        }

        private async void GetReaderTypeButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new product
                Product product = new Product
                {

                };

                var url = await CreateProductAsync(product, "GetReaderType");
                //Console.WriteLine($"Created at {url}");

            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
                MessageBox.Show("ERRORE");
            }
        }

        async void GetIdentifiers()
        {
            try
            {
                // Create a new product
                Product product = new Product
                {
                    OutputAs = "Hex5"
                };

                while (true)
                {
                    
                    HttpResponseMessage respons = await client.PostAsJsonAsync(
                        "GetIdentifiers", product);
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

        private void SetReaderTypeButton_Click(object sender, EventArgs e)
        {
            SetReaderTypeForm setReaderTypeForm = new SetReaderTypeForm();
            setReaderTypeForm.Show();
            
        }
    }

    public class Product
    {
        public string OutputAs { get; set; }

        public bool BLEEnabled { get; set; }
        public bool MifareEnabled { get; set; }
        public bool FSKEnabled { get; set; }
        public bool ASKEnabled { get; set; }




    }
}
