﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using System.Web.Script.Serialization;
namespace SHARED.Libraries
{
    public class StringHelper
    {
        /// <summary>
        /// Hàm chuyển chuỗi sang int;
        /// null, "", FAIL => 0
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int toInt(String input)
        {
            if (input == null || input.Equals(""))
            {
                return 0;
            }
            try
            {
                int re = Convert.ToInt32(input);
                return re;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        /// <summary>
        /// SHA1 thuần, trả về kiểu HOA </summary>
        public static String SHA1(String obj)
        {
            if (obj == null)
            {
                obj = "";
            }
            byte[] b1 = System.Text.Encoding.UTF8.GetBytes(obj);
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                byte[] hash = sha1.ComputeHash(b1);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                {
                    var hex = b.ToString("x2");
                    sb.Append(hex);
                }

                return sb.ToString().ToUpper();
            }
        }
        /// <summary>
        /// SHA1 chuỗi với salt, trả về kiểu HOA </summary>
        public static String SHA1_Salt(String obj)
        {
            String salt1 = "34@3%%6CV*&_+";
            String salt2 = "hg13@';,Ghfya";
            obj = salt1 + obj + salt2;
            return StringHelper.SHA1(obj);
        }
        public static String generateConnectionString(String db_host, String db_name, Boolean useWA=true, String db_username="", String db_password="", String port="", int TimeOut=-1)
        {
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();

            sqlBuilder.DataSource = db_host;

            if (!port.Equals(""))
            {
                sqlBuilder.DataSource += "," + port;
            }
            if (!db_name.Equals(""))
            {
                sqlBuilder.InitialCatalog = db_name;
            }
            if (!useWA)
            {
                sqlBuilder.UserID = db_username;
                sqlBuilder.Password = db_password;
                sqlBuilder.IntegratedSecurity = false;
            }
            else
            {
                sqlBuilder.IntegratedSecurity = true;
            }
            if (TimeOut > 0)
            {
                sqlBuilder.ConnectTimeout = TimeOut;//seconds
            }
            //Debug.WriteLine("StringHelper: "+sqlBuilder.ToString());
            return sqlBuilder.ToString();
        }
        /// <summary>
        /// Chuyển chuổi có dấu thành không dấu </summary>
        public static string CoDauThanhKhongDau(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        /// <summary>
        /// Loc bo cac ky tu dac biet ra khoi chuoi,
        /// { '-', '_', '.', ',', '!', '?', '#', '@', '$', '~', '`', '^', '%', '&', '*', '(', ')', '+', '=', ';', ':', '\'', '"', '[', ']', '{', '}', '|', '\\' };
        /// </summary>
        /// <param name="input"></param>
        /// <param name="replace"></param>
        /// <returns></returns>
        public static String thayDoiKyTuDacBiet(string input = "", string replace = " ")
        {
            string re = input;
            char[] special = { '-', '_', '.', ',', '!', '?', '#', '@', '$', '~', '`', '^', '%', '&', '*', '(', ')', '+', '=', ';', ':', '\'', '"', '[', ']', '{', '}', '|', '\\' };
            foreach (var item in special)
            {
                re = re.Replace(item.ToString(), replace);
            }
            return re;
        }

        /// <summary>
        /// Lọc ký tự đặc biệt. Chỉ còn Chữ, Số _ - </summary>
        public static string LocKyTuDacBiet(string s)
        {
            s = s.Replace(" ","_");
            return Regex.Replace(s, "[^.a-zA-Z0-9_-]", "");
        }

        public static string RandomName(int length)
        {
            string Name = "";
            Random Random = new Random();
            int Num;
            while (Name.Length < length)
            {
                Num = Random.Next(1, 3);
                if (Num == 1)
                {
                    Num = Random.Next(65, 91);
                    Name = Name + Convert.ToChar(Num);
                }
                else
                {
                    Num = Random.Next(0, 10);
                    Name = Name + Num.ToString();
                }
            }
            return Name;
        }

        public static Boolean IsNumber(String str)
        {
            int num;
            if (int.TryParse(str, out num))
                return true;
            return false;
        }

        private static readonly byte[] initVectorBytes = Encoding.ASCII.GetBytes("tu89geji340t89u2");
        private const int keysize = 256;

        public static string Encrypt(string plainText, string passPhrase)
        {
            try
            {
                byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
                using (PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null))
                {
                    byte[] keyBytes = password.GetBytes(keysize / 8);
                    using (RijndaelManaged symmetricKey = new RijndaelManaged())
                    {
                        symmetricKey.Mode = CipherMode.CBC;
                        using (ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes))
                        {
                            using (MemoryStream memoryStream = new MemoryStream())
                            {
                                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                                {
                                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                    cryptoStream.FlushFinalBlock();
                                    byte[] cipherTextBytes = memoryStream.ToArray();
                                    return Convert.ToBase64String(cipherTextBytes);
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string Decrypt(string cipherText, string passPhrase)
        {
            try
            {
                byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
                using (PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null))
                {
                    byte[] keyBytes = password.GetBytes(keysize / 8);
                    using (RijndaelManaged symmetricKey = new RijndaelManaged())
                    {
                        symmetricKey.Mode = CipherMode.CBC;
                        using (ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes))
                        {
                            using (MemoryStream memoryStream = new MemoryStream(cipherTextBytes))
                            {
                                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                                {
                                    byte[] plainTextBytes = new byte[cipherTextBytes.Length];
                                    int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                    return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string toJSON(Dictionary<String,String> input)
        {
            try
            {
                string json = new JavaScriptSerializer().Serialize(input.ToDictionary(item => item.Key.ToString(), item => item.Value.ToString()));
                return json;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static Uri AddParameter(Uri url, string paramName, string paramValue)
        {
            var uriBuilder = new UriBuilder(url);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query.Remove(paramName);
            query[paramName] = paramValue;
            uriBuilder.Query = query.ToString();
            return new Uri(uriBuilder.ToString());
        }

        public static Uri AddParameter(Uri url, string paramName, string paramValue, List<string> listRemove)
        {
            var uriBuilder = new UriBuilder(url);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            for (int i = 0; i < listRemove.Count; i++)
                query.Remove(listRemove.ElementAt(i));
            query.Remove(paramName);
            query[paramName] = paramValue;
            uriBuilder.Query = query.ToString();
            return new Uri(uriBuilder.ToString());
        }

        public static Uri RemoveParameter(Uri url, List<string> listRemove)
        {
            var uriBuilder = new UriBuilder(url);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            for (int i = 0; i < listRemove.Count; i++)
                query.Remove(listRemove.ElementAt(i));
            uriBuilder.Query = query.ToString();
            return new Uri(uriBuilder.ToString());
        }

        public static String ConvertRNToBR(string content)
        {
            try
            {
                if (content.IndexOf("\r\n") != -1)
                    return content.Replace("\r\n", "<br />");
                else
                    return content;
            }
            catch
            {
                return content;
            }
        }

        public static String ConvertBRToRN(string content)
        {
            try
            {
                if (content.IndexOf("<br />") != -1)
                    return content.Replace("<br />", "\r\n");
                else
                    return content;
            }
            catch
            {
                return content;
            }
        }

        public static String SplitCharacter(string content, int number)
        {
            string[] ct = content.Split(' ');
            string str = string.Empty;
            for (int i = 0; i < number - 1; i++)
            {
                str += ct[i] + " ";
            }
            str += ct[number] + "...";
            return str;
        }

        public static bool isCoDau(string key_work="")
        {
            return !CoDauThanhKhongDau(key_work).Equals(key_work);
        }
    }
}
