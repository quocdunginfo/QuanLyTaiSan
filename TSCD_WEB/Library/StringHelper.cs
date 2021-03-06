﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TSCD_WEB.Libraries
{
    public class StringHelper
    {
        public static Uri AddParameter(Uri url, string paramName, string paramValue)
        {
            var uriBuilder = new UriBuilder(url);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query.Remove(paramName);
            query[paramName] = paramValue;
            uriBuilder.Query = query.ToString();
            return new Uri(uriBuilder.ToString());
        }

        public static Uri AddParameter(Uri url, List<string> listParamName, List<string> listParamValue)
        {
            var uriBuilder = new UriBuilder(url);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            for (int i = 0; i < listParamName.Count; i++)
            {
                query.Remove(listParamName.ElementAt(i));
                query[listParamName.ElementAt(i)] = listParamValue.ElementAt(i);
            }
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

        public static String StringViTriPhong(TSCD.Entities.Phong objPhong)
        {
            String strViTri = "";
            if (objPhong.vitri != null)
            {
                if (objPhong.vitri.coso != null)
                {
                    strViTri = string.Format("({0}", objPhong.vitri.coso.ten);
                    if (objPhong.vitri.day != null)
                    {
                        strViTri += string.Format(" - {0}", objPhong.vitri.day.ten);
                        if (objPhong.vitri.tang != null)
                        {
                            strViTri += string.Format(" - {0})", objPhong.vitri.tang.ten);
                        }
                        else
                        {
                            strViTri += ")";
                        }
                    }
                    else
                    {
                        strViTri += ")";
                    }
                }
            }
            return strViTri;
        }
    }
}