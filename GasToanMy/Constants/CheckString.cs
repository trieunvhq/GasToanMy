﻿
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GasToanMy
{
    internal static class CheckString
    {
        public static string NumberToText(double inputNumber, bool suffix = true)
        {
            string[] unitNumbers = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] placeValues = new string[] { "", "nghìn", "triệu", "tỷ" };
            bool isNegative = false;

            if (inputNumber == 0)
                return "không đồng chẵn";

            // -12345678.3445435 => "-12345678"
            string sNumber = inputNumber.ToString("#");
            double number = Convert.ToDouble(sNumber);
            if (number < 0)
            {
                number = -number;
                sNumber = number.ToString();
                isNegative = true;
            }


            int ones, tens, hundreds;

            int positionDigit = sNumber.Length;   // last -> first

            string result = " ";


            if (positionDigit == 0)
                result = unitNumbers[0] + result;
            else
            {
                // 0:       ###
                // 1: nghìn ###,###
                // 2: triệu ###,###,###
                // 3: tỷ    ###,###,###,###
                int placeValue = 0;

                while (positionDigit > 0)
                {
                    // Check last 3 digits remain ### (hundreds tens ones)
                    tens = hundreds = -1;
                    ones = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                    positionDigit--;
                    if (positionDigit > 0)
                    {
                        tens = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                        positionDigit--;
                        if (positionDigit > 0)
                        {
                            hundreds = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                            positionDigit--;
                        }
                    }

                    if ((ones > 0) || (tens > 0) || (hundreds > 0) || (placeValue == 3))
                        result = placeValues[placeValue] + result;

                    placeValue++;
                    if (placeValue > 3) placeValue = 1;

                    if ((ones == 1) && (tens > 1))
                        result = "một " + result;
                    else
                    {
                        if ((ones == 5) && (tens > 0))
                            result = "lăm " + result;
                        else if (ones > 0)
                            result = unitNumbers[ones] + " " + result;
                    }
                    if (tens < 0)
                        break;
                    else
                    {
                        if ((tens == 0) && (ones > 0)) result = "lẻ " + result;
                        if (tens == 1) result = "mười " + result;
                        if (tens > 1) result = unitNumbers[tens] + " mươi " + result;
                    }
                    if (hundreds < 0) break;
                    else
                    {
                        if ((hundreds > 0) || (tens > 0) || (ones > 0))
                            result = unitNumbers[hundreds] + " trăm " + result;
                    }
                    result = " " + result;
                }
            }
            result = result.Trim();
            if (isNegative) result = "Âm " + result;
            return result + (suffix ? " đồng chẵn" : "");
        }
    

        public static bool FormIsOpened(string FormName)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name == FormName)
                {
                    frm.BringToFront();
                    return true;
                }
            }
            return false;
        }

        public static String CreateCodeDonHangChiTiet()
        {
            DataTable dt;
            String Code = "CT1010101010";
            String sq_curent = "";

            try
            {
                using (clsDonHangChiTiet cls = new clsDonHangChiTiet())
                {
                    dt = cls.CreateCodeDonHangChiTiet();
                    if (dt.Rows.Count > 0)
                    {
                        sq_curent = dt.Rows[0]["Code"].ToString().Trim();
                    }

                    if (sq_curent != "" && sq_curent.Length >= 3)
                    {
                        String tmp = sq_curent.Substring(2);
                        int sq = Convert.ToInt32(tmp) + 1;

                        Code = "CT" + sq.ToString();
                    }
                    else Code = "CT1010101010";
                }
            }
            catch (Exception ea)
            {
            }

            return Code;
        }

        public static String CreateCodeDonHang()
        {
            DataTable dt;
            String Code = "HD10101010";
            String sq_curent = "";

            try
            {
                using (clsDonHang cls = new clsDonHang())
                {
                    dt = cls.CreateCodeDonHang();
                    if (dt.Rows.Count > 0)
                    {
                        sq_curent = dt.Rows[0]["Code"].ToString().Trim();
                    }

                    if (sq_curent != "" && sq_curent.Length >= 3)
                    {
                        String tmp = sq_curent.Substring(2);
                        int sq = Convert.ToInt32(tmp) + 1;

                        Code = "HD" + sq.ToString();
                    }
                    else Code = "HD10101010";
                }
            }
            catch (Exception ea)
            {
            }

            return Code;
        }


        public static String Create_CodeKhachHang()
        {
            DataTable dt;
            String Code = "KH10101010";
            String sq_curent = "";

            try
            {
                using (clsKhachHang cls = new clsKhachHang())
                {
                    dt = cls.Create_CodeKhachHang();
                    if (dt.Rows.Count > 0)
                    {
                        sq_curent = dt.Rows[0]["Code"].ToString().Trim();
                    }

                    if (sq_curent != "" && sq_curent.Length >= 3)
                    {
                        String tmp = sq_curent.Substring(2);
                        int sq = Convert.ToInt32(tmp) + 1;

                        Code = "KH" + sq.ToString();
                    }
                    else Code = "KH10101010";
                }
            }
            catch (Exception ea)
            {
            }

            return Code;
        }

        public static String creatCodeSanPham()
        {
            DataTable dt;
            String Code = "SP10101010";
            String sq_curent = "";

            try
            {
                using (clsSanPham cls = new clsSanPham())
                {
                    dt = cls.Select_CodeSanPham();
                    if (dt.Rows.Count > 0)
                    {
                        sq_curent = dt.Rows[0]["Code"].ToString().Trim();
                    }

                    if (sq_curent != "" && sq_curent.Length >= 3)
                    {
                        String tmp = sq_curent.Substring(2);
                        int sq = Convert.ToInt32(tmp) + 1;

                        Code = "SP" + sq.ToString();
                    }
                    else Code = "SP10101010";
                }
            }
            catch (Exception ea)
            {
            }

            return Code;
        }

        //=======================================
        public static string EncodeMD5(string Metin)
        {
            MD5CryptoServiceProvider MD5Code = new MD5CryptoServiceProvider();
            byte[] byteDizisi = Encoding.UTF8.GetBytes(Metin);
            byteDizisi = MD5Code.ComputeHash(byteDizisi);
            StringBuilder sb = new StringBuilder();
            foreach (byte ba in byteDizisi)
            {
                sb.Append(ba.ToString("x2").ToUpper());
            }
            return sb.ToString();
        }

        public static String creatSoChungTuXuatContDK()
        {
            DataTable dt;
            String SoCT = "XC1";
            String sq_curent = "";

            try
            {
                using (clsThin cls = new clsThin())
                {
                    dt = cls.Tr_Select_SoChungTuXuatContDK();
                    if (dt.Rows.Count > 0)
                    {
                        sq_curent = dt.Rows[0]["SoChungTu"].ToString().Trim();
                    }

                    if (sq_curent != "" && sq_curent.Length >= 3)
                    {
                        String tmp = sq_curent.Substring(2);
                        int sq = Convert.ToInt32(tmp) + 1;

                        SoCT = "XC" + sq.ToString();
                    }
                    else SoCT = "XC1";
                }

                
            }
            catch (Exception ea)
            {

            }

            return SoCT;
        }


        //
        public static String creatMaDinhMucSL()
        {
            DataTable dt;
            String s = "DM000000";
            String maDinhMuc = "";
            String sq_curent = "";

            try
            {
                using (clsThin cls = new clsThin())
                {
                    dt = cls.Tr_Select_CreateMaDinhMucSL();
                    if (dt.Rows.Count > 0)
                    {
                        sq_curent = dt.Rows[0]["MaDinhMuc"].ToString().Trim();
                    }
                }

                if (sq_curent != "" && sq_curent.Length >= 8)
                {
                    String tmp = sq_curent.Substring(2);
                    int sq = Convert.ToInt32(tmp) + 1;

                    if (sq >= 999999)
                    {
                        MessageBox.Show("Không thể tạo mã định mức sản lượng mới. Mã hiện tại đã lớn hơn DM999999!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    maDinhMuc = s.Substring(0, 8 - (sq.ToString()).Length) + sq.ToString();
                }
                else maDinhMuc = "DM000001";
            }
            catch (Exception ea)
            {

            }

            return maDinhMuc;
        }

        //
        public static String creatMaKhachHang()
        {
            DataTable dt;
            String s = "KH0000";
            String maDinhMuc = "";
            String sq_curent = "";

            try
            {
                using (clsThin cls = new clsThin())
                {
                    dt = cls.Tr_Select_CreateMaKhachHang();
                    if (dt.Rows.Count > 0)
                    {
                        sq_curent = dt.Rows[0]["MaKH"].ToString().Trim();
                    }
                }

                //sq_curent = LoaiPhong_db.selectMLP_max();

                if (sq_curent != "" && sq_curent.Length >= s.Length)
                {
                    String tmp = sq_curent.Substring(2);
                    int sq = Convert.ToInt32(tmp) + 1;

                    if (sq >= 9999)
                    {
                        MessageBox.Show("Không thể tạo mã định mức sản lượng mới. Mã hiện tại đã lớn hơn KH9999!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    maDinhMuc = s.Substring(0, s.Length - (sq.ToString()).Length) + sq.ToString();
                }
                else maDinhMuc = "KH0001";
            }
            catch (Exception ea)
            {

            }

            return maDinhMuc;
        }

        //
        public static String creatMaNhanSu()
        {
            DataTable dt;
            String s = "000000";
            String maNhanSu = "";
            String sq_curent = "";

            try
            {
                using (clsThin cls = new clsThin())
                {
                    dt = cls.Tr_Select_CreateMaNhanSu();
                    if (dt.Rows.Count > 0)
                    {
                        sq_curent = dt.Rows[0]["MaNhanVien"].ToString().Trim();
                    }
                }

                //sq_curent = LoaiPhong_db.selectMLP_max();

                //if (sq_curent != "" && sq_curent.Length >= 8)
                //{
                //    String tmp = sq_curent.Substring(2);
                //    int sq = Convert.ToInt32(tmp) + 1;

                //    if (sq >= 99999)
                //    {
                //        MessageBox.Show("Không thể tạo mã nhân viên mới. Mã nhân viên hiện tại đã lớn hơn 99999!",
                //            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    }
                //    //maNhanSu = s.Substring(0, 8 - (sq.ToString()).Length) + sq.ToString();
                //}
                if (sq_curent != "" && sq_curent.Length >= 5)
                {
                    int sq = Convert.ToInt32(sq_curent) + 1;
                    maNhanSu = sq.ToString();
                }
                else maNhanSu = "100001";
            }
            catch(Exception ea)
            {

            }

            return maNhanSu;
        }


        public static bool CheckIsNumber(string Value)
        {
            double OutVal;
            if (Double.TryParse(Value, out OutVal))
            {
                // it is a number
                return true;
            }
            else
            {
                // it is not a number
                return false;
            }
        }

        private static double TinhToan(string str)
        {
            try
            {
                //double result = Convert.ToDouble(new DataTable().Compute("(3+3)*2+1", null));
                double result = Convert.ToDouble(new DataTable().Compute(str, null));

                return result;
            }
            catch { return 0; }
        }


        public static string CheckMailString(string str)
        {
            if (str.Length < 1)
            {
                return "Chưa nhập Mail";
            }
            if (str.Contains("@"))
            {
                string[] arrStr = str.Split('@');
                if (arrStr.Length == 2 && arrStr[0].Length > 0 && arrStr[1].Length > 0 && arrStr[1].Contains("."))
                {
                    byte[] asciiBytes = Encoding.ASCII.GetBytes(arrStr[0]);
                    for (int i = 0; i < asciiBytes.Length; ++i)
                    {

                        if ((asciiBytes[i] > 57 && asciiBytes[i] < 65) ||
                            (asciiBytes[i] > 90 && asciiBytes[i] < 95) || (asciiBytes[i] == 96) ||
                            (asciiBytes[i] > 122) || asciiBytes[i] == 47 || (asciiBytes[i] < 46))
                        {
                            return "Mail không đúng! Vui lòng kiểm tra lại!";
                        }
                    }
                    asciiBytes = Encoding.ASCII.GetBytes(arrStr[1]);
                    for (int i = 0; i < asciiBytes.Length; ++i)
                    {

                        if ((asciiBytes[i] > 57 && asciiBytes[i] < 65) ||
                            (asciiBytes[i] > 90 && asciiBytes[i] < 95) || (asciiBytes[i] == 96) ||
                            (asciiBytes[i] > 122) || asciiBytes[i] == 47 || (asciiBytes[i] < 46))
                        {
                            return "Mail không đúng! Vui lòng kiểm tra lại!";
                        }
                    }
                    return "OK";
                }
                else
                {
                    return "Mail không đúng! Vui lòng kiểm tra lại!";
                }
            }
            else
            {
                return "Mail không đúng! Vui lòng kiểm tra lại!";
            }
        }
        public static bool CheckSqlInjection(string str)
        {
            if (str.ToLower().Contains(" select ") || str.ToLower().Contains(" delete ") ||
                str.ToLower().Contains(" update ") || str.ToLower().Contains(" insert ") ||
                str.ToLower().Contains(" where ") || str.ToLower().Contains(" and ") ||
                str.ToLower().Contains(" or ") || str.ToLower().Contains(" create ") ||
                str.ToLower().Contains(" alter ") || str.ToLower().Contains(" exec "))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool CheckChuBay(string str)
        {
            if (str.ToLower().Replace(" ", "").Contains("địt"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Contains("lồn"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Contains("buồi"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Contains("cặc"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Contains("đụ"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Contains("đéo"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Contains("đít"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Contains("chó"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Contains("mẹ"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Contains("đóng gạch"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Contains("bướm"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Contains("dái"))
            {
                return false;
            }
            //
            if (str.ToLower().Replace(" ", "").Contains("dái"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Contains("tinh trùng"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Contains("tinh trung"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Contains("tinh chùng"))
            {
                return false;
            }
            //
            if (str.ToLower().Replace(" ", "").Contains("tinh chung"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Contains("hạt le"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Contains("dong gach"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Contains("đóng gach"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Contains("chim"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Contains("chym"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Contains("buòi"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Contains("buôi"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Contains("lòn"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Contains("đù"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Contains("má"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Contains("bím"))
            {
                return false;
            }
            //
            if (str.ToLower().Replace(" ", "").Contains("vú"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Replace(" ", "").Contains("zú"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Replace(" ", "").Contains("bố"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Replace(" ", "").Contains("lông"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Replace(" ", "").Contains("dkm"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Replace(" ", "").Contains("súcsinh"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Replace(" ", "").Contains("màngtrinh"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Replace(" ", "").Contains("conđỹ"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Replace(" ", "").Contains("cave"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Replace(" ", "").Contains("giaocấu"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Replace(" ", "").Contains("giaohợp"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Replace(" ", "").Contains("hạtle"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Replace(" ", "").Contains("liếm"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Replace(" ", "").Contains("đónggạch"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Replace(" ", "").Contains("thổikèn"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Replace(" ", "").Contains("sócrọ"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Replace(" ", "").Contains("vkl"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Replace(" ", "").Contains("dm"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Replace(" ", "").Contains("tinhtrùng"))
            {
                return false;
            }
            if (str.ToLower().Replace(" ", "").Replace(" ", "").Contains("vếu"))
            {
                return false;
            }
            return str.ToLower().Replace(" ", "").Replace(" ", "").Contains("thằngngu")
                ? false
                : !str.ToLower().Replace(" ", "").Replace(" ", "").Contains("cụ");
        }
        public static string CheckUserNameString(string userName)
        {
            if (userName.Length < 1)
            {
                return "Chưa nhập tài khoản";
            }
            if (userName.Length < 5)
            {
                return "Tài khoản > 4 ký tự";
            }
            if (!CheckChuBay(userName))
            {
                return "Hãy lịch sự";
            }
            byte[] asciiBytes = Encoding.ASCII.GetBytes(userName);
            for (int i = 0; i < asciiBytes.Length; ++i)
            {
                if (asciiBytes[i] < 48 || (asciiBytes[i] > 57 && asciiBytes[i] < 65) || (asciiBytes[i] > 90 && asciiBytes[i] < 97)
                    || (asciiBytes[i] > 122))
                {

                    return "Tài khoản chỉ gồm chữ không dấu và số";
                }
            }
            return "OK";
        }
        public static string CheckPassString(string str)
        {
            if (str.Length < 1)
            {
                return "Chưa nhập mật khẩu";
            }
            byte[] asciiBytes = Encoding.ASCII.GetBytes(str);
            for (int i = 0; i < asciiBytes.Length; ++i)
            {
                if (asciiBytes[i] < 33 || asciiBytes[i] > 126)
                {

                    return "Mật khẩu chứa tiếng việt và dấu cách";
                }
            }
            return "OK";
        }
        public static int CheckStrength(string password)
        {
            int score = 1;

            if (password.Length < 1)
                return 0;
            if (password.Length < 4)
            {
                return 1;
            }

            if (password.Length >= 8)
                score++;
            if (password.Length >= 12)
                score++;
            if (Regex.Match(password, @"/\d+/", RegexOptions.ECMAScript).Success)
                score++;
            if (Regex.Match(password, @"/[a-z]/", RegexOptions.ECMAScript).Success &&
              Regex.Match(password, @"/[A-Z]/", RegexOptions.ECMAScript).Success)
                score++;
            if (Regex.Match(password, @"/.[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]/", RegexOptions.ECMAScript).Success)
                score++;

            return score;
        }

        public static string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
    "đ",
    "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
    "í","ì","ỉ","ĩ","ị",
    "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
    "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
    "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
    "d",
    "e","e","e","e","e","e","e","e","e","e","e",
    "i","i","i","i","i",
    "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
    "u","u","u","u","u","u","u","u","u","u","u",
    "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }

        public static string ToFractions(this double number, int precision = 4)
        {
            int w, n, d;
            RoundToMixedFraction(number, precision, out w, out n, out d);
            var ret = $"{w}";
            if (w > 0)
            {
                if (n > 0)
                    ret = $"{w} {n}/{d}";
            }
            else
            {
                if (n > 0)
                    ret = $"{n}/{d}";
            }
            return ret;
        }

        static void RoundToMixedFraction(double input, int accuracy, out int whole, out int numerator, out int denominator)
        {
            double dblAccuracy = (double)accuracy;
            whole = (int)(Math.Truncate(input));
            var fraction = Math.Abs(input - whole);
            if (fraction == 0)
            {
                numerator = 0;
                denominator = 1;
                return;
            }
            var n = Enumerable.Range(0, accuracy + 1).SkipWhile(e => (e / dblAccuracy) < fraction).First();
            var hi = n / dblAccuracy;
            var lo = (n - 1) / dblAccuracy;
            if ((fraction - lo) < (hi - fraction)) n--;
            if (n == accuracy)
            {
                whole++;
                numerator = 0;
                denominator = 1;
                return;
            }
            var gcd = GCD(n, accuracy);
            numerator = n / gcd;
            denominator = accuracy / gcd;
        }

        static int GCD(int a, int b)
        {
            if (b == 0) return a;
            else return GCD(b, a % b);
        }

        public static int ConvertTo_Int_My(object str)
        {
            if (str == null)
                return 0;

            string str_2_ = str.ToString();

            if (str_2_ == "")
                return 0;

            int temp_ = 0;
            try
            {
                temp_ = Convert.ToInt32(str);
            }
            catch
            {
                try
                {
                    str_2_ = str_2_.Replace(",", "*");
                    str_2_ = str_2_.Replace(".", ",");
                    str_2_ = str_2_.Replace("*", ".");
                    temp_ = Convert.ToInt32(str_2_);
                }
                catch
                {
                    return 0;
                }
            }
            return temp_;
        }
        
        public static double ConvertToDouble_My(object str)
        {
            if (str == null)
                return 0;

            string str_2_ = str.ToString();

            if (str_2_ == "")
                return 0;

            double temp_ = 0;
            try
            {
                temp_ = Convert.ToDouble(new DataTable().Compute(str_2_, null));
                //Convert.ToDouble(str);
            }
            catch (Exception ex)
            {
                try
                {
                    try { temp_ = Convert.ToDouble(str); }
                    catch
                    {
                        str_2_ = str_2_.Replace(",", "*");
                        str_2_ = str_2_.Replace(".", ",");
                        str_2_ = str_2_.Replace("*", ".");
                        temp_ = Convert.ToDouble(str_2_);
                    }
                }
                catch {
                    return 0;
                }
            }
            return temp_;
        }

        public static decimal ConvertToDecimal_My(object str)
        {
            if (str == null)
                return 0;
            string str_2_ = str.ToString();
            decimal temp_ = 0;
            try
            {
                //temp_ = Convert.ToDecimal(str);
                temp_ = Convert.ToDecimal(new DataTable().Compute(str.ToString(), null));
            }
            catch
            {
                try
                {
                    str_2_ = str_2_.Replace(",", "*");
                    str_2_ = str_2_.Replace(".", ",");
                    str_2_ = str_2_.Replace("*", ".");
                    temp_ = Convert.ToDecimal(str_2_);
                }
                catch
                {
                    return 0;
                }
            }
            return temp_;
        }

        public static string ChuanHoaHoTen(string FullName)
        {
            string Result = "";
            FullName = FullName.Trim();

            /* 
             * Trong khi còn tìm thấy 2 khoảng trắng
             * thì thực hiện thay thế 2 khoảng trắng bằng 1 khoảng trắng
             */
            while (FullName.IndexOf("  ") != -1)
            {
                FullName = FullName.Replace("  ", " ");
            }
            /*
             * Cắt chuỗi họ tên ra thành mảng các từ.
             * Sau đó duyệt mảng để chuẩn hoá từng từ một.
             * Khi duyệt mỗi từ ta thực hiện cắt ra chữ cái đầu trên và lưu trong biến FirstChar
             * Cắt các chữ cái còn lại và lưu trong biến OtherChar.
             * Thực hiện viết hoa chữ cái đầu và viết thường các chữ cái còn lại.
             * Cuối cùng là lưu chữ vừa chuẩn hoá vào biến Result.
             */
            string[] SubName = FullName.Split(' ');

            for (int i = 0; i < SubName.Length; i++)
            {
                string FirstChar = SubName[i].Substring(0, 1);
                string OtherChar = SubName[i].Substring(1);
                SubName[i] = FirstChar.ToUpper() + OtherChar.ToLower();
                Result += SubName[i] + " ";
            }

            return Result;
        }
    }
}
