namespace ESignSDK.Responses
{
    public enum ReturnTypeCode
    {
        /// <summary>
        /// 执行流程中未知错误
        /// </summary>
        UnknowError = -9999,

        /// <summary>
        /// 执行过程中捕获 Exception
        /// </summary>
        Exception = -7700,

        /// <summary>
        /// 成功
        /// </summary>
        Success = 0,
        /// <summary>
        /// 1.token过期了
        /// 2.header请求头不正确
        /// 3.apiurl和应用ID环境不对应，例如apiurl是模拟环境，应用ID是正式环境的
        /// </summary>        
        UnAuth = 401,

        //个人账号创建
        /// <summary>
        /// 账号已存在
        /// </summary>
        AccountExists = 53000000,

        /// <summary>
        /// 账号不存在
        /// </summary>
        AccountNotExists = 53000001,

        /// <summary>
        /// 账号类型不匹配
        /// </summary>
        AccountNotMatched = 53000002,

        //修改
        /// <summary>
        /// 证件信息冲突
        /// </summary>
        CardInfoConflict = 53000003,

        //修建流程时的问题
        /// <summary>
        /// 查询项目开发者账户失败 项目无效或项目开发者oid不存在.
        /// </summary>
        DeveloperAccountError = 1435102,

        /// <summary>
        /// 	发起方账号不存在-XXXX   发起方账号无效
        /// </summary>
        InitatorAccountIdError = 1437123,

        /// <summary>
        /// 付费账号不存在-XXXX    付费方账号无效
        /// </summary>
        PaidAccountError = 1437124,

        /// <summary>
        /// 	非草稿状态不允许开启流程    流程不是草稿状态, 已经发起或已经完结
        /// </summary>
        FlowCanotStart = 1437108,

        /// <summary>
        /// 	流程没有文档不允许开启流程   流程没有添加签署文档, 不能开启流程
        /// </summary>
        FlowCanotStartWithNoneDoc =
            1437109,

        /// <summary>
        /// 流程没有签署区不允许开启流程  自动归档场景下, 流程还没有添加签署区, 不能开启流程
        /// </summary>
        FlowHasNoneSignArea = 1437110,

        /// <summary>
        /// 	机构账户中签署份数不足，请购买套餐后再操作   当前机构签署份数不足且当前操作用户是机构管理员
        /// </summary>
        FlowOrgBalanceNotEnough = 1435404,

        /// <summary>
        ///   机构账户中签署份数不足，请联系管理员（%s，%s）购买套餐后再操作   当前机构签署份数不足且当前操作用户不是机构管理员
        /// </summary>
        FlowOrgBalanceNotEnough2 = 1435405,

        /// <summary>
        /// 账户中签署份数不足，请购买套餐后再操作 当前个人账户签署份数不足
        /// </summary>
        FlowAccountBalanceNotEnough = 1435403,


        /// <summary>
        /// 	非开启状态不允许撤回流程    只能撤销状态为签署中的流程
        /// </summary>
        FlowCannotRevoke = 1437111,

        /// <summary>
        /// 	非开启状态不允许归档流程    不能归档状态不是签署中的流程
        /// </summary>
        FlowNotStartCannotArchive = 1437112,

        /// <summary>
        /// 	签署区没有全部完成   签署区没有全部完成签署, 不能归档
        /// </summary>
        FlowSignAreaNotCompleted = 1437113,
        /// <summary>
        /// 流程已归档
        /// </summary>
        FlowAlredyArchived = 1437136,
    }
}