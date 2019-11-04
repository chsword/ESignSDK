using System;
using System.Security.Cryptography;
using System.Text;

namespace ESignSDK
{
    public class Md5Utils
    {
        //public IActionResult Evidence(IFormFile file)
        //{
        //    if (file == null) return View();
        //    string md5;
        //    using (var stream = new MemoryStream())
        //    {
        //        file.CopyTo(stream);
        //        stream.Position = 0;
        //        md5 = AbstractFile(stream);
        //        ViewBag.Md5 = md5;

        //    }

        //    var contract = _db.Contract.FirstOrDefault(c => c.Hash == md5);
        //    return View(contract);
        //}
        public static byte[] Md5(byte[] bytes)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] retVal = md5.ComputeHash(bytes);
            return retVal;
        }

        public static string Md5Base64(string str)
        {
            return AbstractFile(Encoding.UTF8.GetBytes(str));
        }

        public static string Md5Base64(byte[] bytes)
        {
            return AbstractFile(bytes);
        }

        static string AbstractFile(byte[] bytes)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] retVal = md5.ComputeHash(bytes);

            return Convert.ToBase64String(retVal);
        }
    }
}