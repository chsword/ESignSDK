using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ESignSDK.Test
{
    [TestClass]
    public class UtilTest
    {
        [TestMethod]
        public void MyTestMethod()
        {
            var t = @"CRED_ORG_USCC 统一社会信用代码，默认值
CRED_ORG_CODE 组织机构代码证
CRED_ORG_REGCODE 工商注册号
CRED_ORG_BUSINESS_REGISTTATION_CODE 工商登记证
CRED_ORG_TAX_REGISTTATION_CODE 税务登记证
CRED_ORG_LEGAL_PERSON_CODE 法人代码证
CRED_ORG_ENT_LEGAL_PERSON_CODE 事业单位法人证书
CRED_ORG_SOCIAL_REG_CODE 社会团体登记证书
CRED_ORG_PRIVATE_NON_ENT_REG_CODE 民办非机构登记证书
CRED_ORG_FOREIGN_ENT_REG_CODE 外国机构常驻代表机构登记证
CRED_ORG_GOV_APPROVAL 政府批文
CODE_ORG_CUSTOM 自定义
CRED_ORG_UNKNOWN 未知证件类型".Replace("\r", "");
            foreach (var s in t.Split('\n'))
            {
                var arr = s.Split(" ");
                Console.WriteLine("/// <summary>");
                Console.WriteLine("/// " + arr[1]);
                Console.WriteLine("/// </summary>");
                Console.WriteLine("public static string " + arr[0] + " = \"" + arr[0] + "\";");
            }
        }
    }
}