using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
namespace windowClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HttpClient client = new HttpClient();

          HttpResponseMessage mg=  client.GetAsync("http://localhost:7777/api/courses").Result;
            if (mg.StatusCode== HttpStatusCode.OK)
            {
               List<StudentData> st = mg.Content.ReadAsAsync<List<StudentData>>().Result;
                dataGridView1.DataSource = st;
            }
        }
    }
}
