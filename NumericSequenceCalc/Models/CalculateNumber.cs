using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace NumericSequenceCalc.Models
{
    public class CalculateNumber
    {
        public string CalculateSequence(int calcType, int number)
        {
            string strResult = string.Empty;
            StringBuilder sbResult = new StringBuilder();
            if (calcType == 1)
            {
                for (int i = 1; i <= number; i++)
                {

                    sbResult.Append(i).Append(",");

                }
            }
            else if (calcType == 2)
            {
                for (int i = 1; i <= number; i++)
                {
                    if (i % 2 != 0)
                    {
                        sbResult.Append(i).Append(",");
                    }
                }
            }
            else if (calcType == 3)
            {
                for (int i = 1; i <= number; i++)
                {
                    if (i % 2 == 0)
                    {
                        sbResult.Append(i).Append(",");
                    }
                }
            }
            else if (calcType == 4)
            {
                for (int i = 1; i <= number; i++)
                {
                    if ((i % 3 == 0) && (i % 5 == 0))
                    {
                        sbResult.Append("Z,");
                    }
                    else if (i % 3 == 0)
                    {
                        sbResult.Append("C,");
                    }
                    else if (i % 5 == 0)
                    {
                        sbResult.Append("E,");
                    }
                    else
                    {
                        sbResult.Append(i).Append(",");
                    }
                }
            }
            else if (calcType == 5)
            {
                long lNum1 = 0;
                long lNum2 = 1;
                long lSum = 1;
                sbResult.Append("1,");
                for (int i = 2; i <= number; i++)
                {
                    lSum = lNum1 + lNum2;
                    sbResult.Append(lSum).Append(",");
                    lNum1 = lNum2;
                    lNum2 = lSum;
                }
            }

            strResult = sbResult.ToString();
            if (strResult.Length>1)
            {
                strResult = strResult.Substring(0, strResult.Length - 1);

            }
            return strResult;
        }
    }
}