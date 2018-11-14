using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Entity.API
{
    public enum ReponseCode
    {
        #region 执行成功

        /// <summary>
        /// 执行成功(查询，新增，更新，删除等)
        /// 返回（0000）
        /// </summary>
        [Description("执行成功")]
        Success = 0000,

        /// <summary>
        /// 查询成功，但无结果
        /// 返回(0001)
        /// </summary>
        [Description("查询成功，但无结果")]
        SuccessWithoutResult = 0001,

        /// <summary>
        /// 验证失败
        /// </summary>
        [Description("token验证失败")]
        VerifyFail = 10,

        #endregion

        #region 参数错误

        /// <summary>
        /// 参数错误，未明确具体类型
        /// </summary>
        [Description("参数错误")]
        ParameterError = 1000,

        /// <summary>
        /// 缺少参数
        /// </summary>
        [Description("缺少参数")]
        ParameterMissing = 1001,

        /// <summary>
        /// 参数类型错误
        /// </summary>
        [Description("参数类型错误")]
        ParameterTypeError = 1002,

        /// <summary>
        /// 参数值错误，如超出取值范围等
        /// </summary>
        [Description("参数值错误")]
        ParameterValueError = 1003,

        #endregion

        #region 数据错误

        /// <summary>
        /// 数据错误,未明确具体错误类型
        /// </summary>
        [Description("数据错误")]
        DataError = 2000,

        /// <summary>
        /// 数据库连接失败
        /// </summary>
        [Description("数据库连接失败")]
        DdConnectFail = 2001,

        /// <summary>
        /// 数据查询失败
        /// </summary>
        [Description("数据查询失败")]
        SearchFail = 2002,

        /// <summary>
        /// 数据新增失败
        /// </summary>
        [Description("数据新增失败")]
        InsertFail = 2003,

        /// <summary>
        /// 数据更新失败
        /// </summary>
        [Description("数据更新失败")]
        UpdateFail = 2004,

        /// <summary>
        /// 数据删除失败
        /// </summary>
        [Description("数据删除失败")]
        DeleteFail = 2005,

        /// <summary>
        /// 数据新增失败
        /// </summary>
        [Description("数据新增失败")]
        AddFail = 2006,

        #endregion

        #region 网络错误

        /// <summary>
        /// 网络错误，未明确具体错误
        /// </summary>
        [Description("网络错误")]
        NetworkError = 3000,

        /// <summary>
        /// 网络连接失败
        /// </summary>
        [Description("网络连接失败")]
        NetworkConnectFail = 3001,

        /// <summary>
        /// 拒绝访问
        /// </summary>
        [Description("拒绝访问")]
        AccessDenied = 3002,

        /// <summary>
        /// 网络连接超时
        /// </summary>
        [Description("网络连接超时")]
        NetworkConnectTimeout = 3003,


        #endregion

        #region 短信发送错误
        /// <summary>
        /// 短信发送失败
        /// </summary>
        [Description("短信发送失败")]
        SmsSendFail = 4000,

        /// <summary>
        /// 彩信发送失败
        /// </summary>
        [Description("彩信发送失败")]
        MmsSendFail = 4001,

        /// <summary>
        /// 短信彩信发送失败
        /// </summary>
        [Description("短信彩信发送失败")]
        SmsAndMmsSendFail = 4002,
        #endregion

        #region 权限认证错误
        /// <summary>
        /// 权限认证失败，未明确具体类型
        /// </summary>
        [Description("权限认证失败")]
        AuthenticateFail = 8000,

        /// <summary>
        /// 账号或密码错误
        /// </summary>
        [Description("账号或密码错误")]
        AccountOrPasswordAuthenticateFail = 8001,

        /// <summary>
        /// 账号不存在
        /// </summary>
        [Description("账号不存在")]
        AccountNotExist = 8002,

        /// <summary>
        /// 数字签名认证失败
        /// </summary>
        [Description("数字签名认证失败")]
        SignatureAuthenticateFail = 8003,

        /// <summary>
        /// 设备秘钥查找失败
        /// </summary>
        [Description("设备秘钥查找失败")]
        MachineDesKeyQueryFail = 8004,
        #endregion

        #region 未知异常
        /// <summary>
        /// 未知异常
        /// </summary>
        [Description("未知异常")]
        UnknownError = 5000,
        #endregion

        #region 报文错误
        /// <summary>
        /// 报文错误，未明确具体类型
        /// </summary>
        [Description("报文错误")]
        MessageError = 9000,

        /// <summary>
        /// 报文格式错误
        /// </summary>
        [Description("报文格式错误")]
        MessageFormatError = 9001,

        /// <summary>
        /// 缺少节点
        /// </summary>
        [Description("缺少节点")]
        MessageNodeMissing = 9002,

        /// <summary>
        /// 缺少服务名
        /// </summary>
        [Description("缺少服务名")]
        ServiceNameLack = 9003,

        /// <summary>
        /// 服务名错误
        /// </summary>
        [Description("服务名错误")]
        ServiceNameError = 9004,

        /// <summary>
        /// 模板错误
        /// </summary>
        [Description("模板错误")]
        TemplateError = 9005

        #endregion
    }
}
