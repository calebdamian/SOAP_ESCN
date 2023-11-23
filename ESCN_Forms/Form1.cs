using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESCN_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ESCN_Service.Service1Client client = new ESCN_Service.Service1Client();

            string resultado = client.GetData(5, 1000);

            MessageBox.Show(resultado);


            ESCN_Service.CompositeType composite = new ESCN_Service.CompositeType();      
            composite.BoolValue = true;

            var res2 = client.GetDataUsingDataContract(composite);
            MessageBox.Show(res2.StringValue);
        }
    }
}
