using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
namespace AP_Gestion_HALAOUI.Controller
{
    public class CT_AP
    {
        public string MD5(string text)
        { 
                MD5 md5 = System.Security.Cryptography.MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(text);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString().ToLower();
        }
    }
}
