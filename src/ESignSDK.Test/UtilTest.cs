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
            var t = @"CRED_ORG_USCC ͳһ������ô��룬Ĭ��ֵ
CRED_ORG_CODE ��֯��������֤
CRED_ORG_REGCODE ����ע���
CRED_ORG_BUSINESS_REGISTTATION_CODE ���̵Ǽ�֤
CRED_ORG_TAX_REGISTTATION_CODE ˰��Ǽ�֤
CRED_ORG_LEGAL_PERSON_CODE ���˴���֤
CRED_ORG_ENT_LEGAL_PERSON_CODE ��ҵ��λ����֤��
CRED_ORG_SOCIAL_REG_CODE �������Ǽ�֤��
CRED_ORG_PRIVATE_NON_ENT_REG_CODE ���ǻ����Ǽ�֤��
CRED_ORG_FOREIGN_ENT_REG_CODE ���������פ��������Ǽ�֤
CRED_ORG_GOV_APPROVAL ��������
CODE_ORG_CUSTOM �Զ���
CRED_ORG_UNKNOWN δ֪֤������".Replace("\r", "");
            foreach (var s in t.Split('\n'))
            {
                var arr = s.Split(" ");
                Console.WriteLine("/// <summary>");
                Console.WriteLine("/// "+arr[1]);
                Console.WriteLine("/// </summary>");
                Console.WriteLine("public static string " + arr[0]+ " = \"" + arr[0] + "\";");
            }

        }

    }
}