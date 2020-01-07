using DevExpress.Data.Filtering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XpoTools.master;

namespace XpoTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            xpCollection1.Criteria = null;
            xpCollection1.LoadingEnabled = true;
            xpCollection1.Reload();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            PXXT_CODE pxxtcode = new PXXT_CODE(session1);
            pxxtcode.SUB_SYS = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            pxxtcode.rowid = "newrowid";
            pxxtcode.Save();
            xpCollection1.Add(pxxtcode);

        }

        private void btnQuery1_Click(object sender, EventArgs e)
        {

            CriteriaOperator op = new BinaryOperator("CODE", "001");
            CriteriaOperator criteria = CriteriaOperator.Parse("CODE='001'");
            
            //server side
            //xpCollection1.Criteria = op;
            xpCollection1.Criteria = criteria;
            //client side
            //xpCollection1.Filter = op;
            //xpCollection1.Filter = criteria; 

            xpCollection1.LoadingEnabled = true;
            xpCollection1.Reload();

        }
    }
}
