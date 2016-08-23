using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NumericSequenceCalc.Models;

namespace NumericSequenceCalc
{
    public partial class frmNumericCalc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            //CalculateNumber(ddlCalcType.SelectedIndex);
            CalculateNumber calcNumber = new CalculateNumber();
            string strResult = calcNumber.CalculateSequence(ddlCalcType.SelectedIndex, int.Parse(txtNumber.Text.Trim()));
            txtResult.Text = strResult;
        }

        
        //public void CalculateNumber(int CalcType)
        //{
        //    int iNum = int.Parse(txtNumber.Text);
        //    if (CalcType == 1)
        //    {
        //        for (int i = 1; i <= iNum; i++)
        //        {
                    
        //             lbResult.Items.Add(i.ToString());
                    
        //        }  
        //    }
        //    else if (CalcType == 2)
        //    {
        //        for (int i = 1; i <= iNum; i++)
        //        {
        //            if (i % 2 != 0)
        //            {
        //                lbResult.Items.Add(i.ToString());
        //            }
        //        }
        //    }
        //    else if (CalcType == 3)
        //    {
        //        for (int i = 1; i <= iNum; i++)
        //        {
        //            if (i % 2 == 0)
        //            {
        //                lbResult.Items.Add(i.ToString());
        //            }
        //        }
        //    }
        //    else if (CalcType == 4)
        //    {
        //        for (int i = 1; i <= iNum; i++)
        //        {
        //            if ((i % 3 == 0) && (i % 5 == 0))
        //            {
        //                lbResult.Items.Add("Z");
        //            }
        //            else if (i % 3 == 0)
        //            {
        //                lbResult.Items.Add("C");
        //            }
        //            else if (i % 5 == 0)
        //            {
        //                lbResult.Items.Add("E");
        //            }                    
        //            else
        //            {
        //                lbResult.Items.Add(i.ToString());
        //            }
        //        }
        //    }
        //    else if (CalcType==5)
        //    {
        //        long lNum1 = 0;
        //        long lNum2 = 1;
        //        long lSum = 1;                
        //        lbResult.Items.Add("1");
        //        for (int i = 2; i <= iNum; i++)
        //        {
        //            lSum = lNum1 + lNum2;
        //            lbResult.Items.Add(lSum.ToString());
        //            lNum1 =lNum2;
        //            lNum2 = lSum;
        //        }                
        //    }
            

        //}

        
    }
}