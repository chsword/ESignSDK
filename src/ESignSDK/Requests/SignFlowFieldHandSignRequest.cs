using System.Collections.Generic;

namespace ESignSDK.Requests
{
    public class SignFlowFieldHandSignRequest
    {
        public List<SignFieldHandSign> Signfields { get; set; }
    }

    public class SignFieldHandSign : SignField
    {
        /// <summary>
        /// 机构签约类别，当签约主体为机构时必传：2-机构盖章；	
        /// </summary>

        public int ActorIndentityType { get; set; }

        /// <summary>
        /// 是否指定位置，如指定位置则posBean不可为空；
        /// 一旦设置为TRUE，表示用户签署时不允许更新位置	
        /// </summary>
        public bool? AssignedPosbean { get; set; }

        /// <summary>
        /// 签约主体账号标识，即本次签署对应任务的归属方，如传入机构id，则签署完成后，本任务可在企业账号下进行管理，默认是签署操作人个人	
        /// </summary>
        /// 
        public string AuthorizedAccountId { get; set; }

        /// <summary>
        /// 印章类型，支持多种类型时逗号分割，0-手绘印章，1-模版印章，为空不限制	
        /// </summary>
        public string SealType { get; set; } = null;

        /// <summary>
        /// 签署操作人个人账号标识，即操作本次签署的个人，如需e签宝通知用户签署，则系统向该账号下绑定的手机、邮箱发送签署链接	
        /// </summary>
        public string SignerAccountId { get; set; }
    }
}