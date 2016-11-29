using ConsumeWebServiceRest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientTest
{
    public partial class frmClient : Form
    {
        private static CancellationTokenSource _CancellationAsync;
        public frmClient()
        {
            InitializeComponent();
        }

        private async void cmdCnx_Click(object sender, EventArgs e)
        {
            _CancellationAsync = new CancellationTokenSource();
            WSR_Params p = new WSR_Params();
            p.Add("pseudo", txtPseudo.Text);
            WSR_Result r1 = await ConsumeWSR.Call(@"http://localhost:4000/Service.svc/Login", p, TypeSerializer.Json, _CancellationAsync.Token);
            lblPwd.Text = (string)r1.Data;
            p.Add("password", (string)r1.Data);
            WSR_Result r2 = await ConsumeWSR.Call(@"http://localhost:4000/Service.svc/GetPseudos", p, TypeSerializer.Json, _CancellationAsync.Token);

            List<string> lst = new List<string>();
            lst = (List<string>)r2.Data;
            lstPseudo.DataSource = lst;

            //Console.WriteLine("mot de passe : " + r.Data);
        }

        private async void cmdDecnx_Click(object sender, EventArgs e)
        {
            _CancellationAsync = new CancellationTokenSource();
            WSR_Params p = new WSR_Params();
            p.Add("pseudo", txtPseudo.Text);
            p.Add("password", lstPseudo.Text);
            WSR_Result r1 = await ConsumeWSR.Call(@"http://localhost:4000/Service.svc/Logout", p, TypeSerializer.Json, _CancellationAsync.Token);
            
        }
    }
}
