using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;


namespace DataModels.Helpers

{
    public static class HashHundle
    {
        public static string GetHashString(string code)
        {
            if (string.IsNullOrWhiteSpace(code)) throw new ArgumentException();
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(code));
            return Convert.ToBase64String(hash);
        }
    }
}