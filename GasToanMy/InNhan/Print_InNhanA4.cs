﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;


namespace GasToanMy
{
    public partial class Print_InNhanA4 : DevExpress.XtraReports.UI.XtraReport
    {
        public Print_InNhanA4()
        {
            InitializeComponent();
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ////Load label ngay thang nam header:
            //if (_thang <= 9) xrlbThang.Text = "0" + _thang.ToString();
            //else xrlbThang.Text = _thang.ToString();
            //xrlbNam.Text = _nam.ToString();

            ////Load label ngay ky footer:
            //DateTime d = Convert.ToDateTime(pNgay.Value);
            //if (d.Day > 9)
            //{
            //    if (d.Month > 9)
            //    {
            //        lbNgayThangNam.Text = "Ngày " + d.Day
            //                            + " tháng " + d.Month
            //                            + " năm " + d.Year;
            //    }
            //    else
            //    {
            //        lbNgayThangNam.Text = "Ngày " + d.Day
            //                            + " tháng 0" + d.Month
            //                            + " năm " + d.Year;
            //    }

            //}
            //else
            //{
            //    if (d.Month > 9)
            //    {
            //        lbNgayThangNam.Text = "Ngày 0" + d.Day
            //                            + " tháng " + d.Month
            //                            + " năm " + d.Year;
            //    }
            //    else
            //    {
            //        lbNgayThangNam.Text = "Ngày 0" + d.Day
            //                            + " tháng 0" + d.Month
            //                            + " năm " + d.Year;
            //    }
            //}
        }

       
    }
}