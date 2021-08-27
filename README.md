# ESignSDK
E签宝 非标Saas / Pass SDK

[![install from nuget](http://img.shields.io/nuget/v/ESignSDK.svg?style=flat-square)](https://www.nuget.org/packages/ESignSDK)
[![Build status](https://ci.appveyor.com/api/projects/status/ond7marcfp3flqlf/branch/master?svg=true)](https://ci.appveyor.com/project/chsword/esignsdk/branch/master)

## 使用方法
```powershell
Install-Package ESignSDK -Version 1.0.0.17
```
```C#
 var client = new ESignSDKClient(new ESignOption()
            {
                //BaseUrl = "https://smlopenapi.esign.cn",
                BaseUrl = "https://openapi.esign.cn",
                AppId = "your appid",
                AppKey = "your appkey"
            });
  var result = await _client.AccountGet("your person accountId");
  // or var result = _client.AccountGet("your person accountId").Result;
  if (result.Code == ReturnTypeCode.Success)
  {
      Console.WriteLine(result.Data.AccountId);
      Console.WriteLine(result.Data.CardNo);
      Console.WriteLine(result.Data.Mobile);
      Console.WriteLine(result.Data.Name);
      Console.WriteLine(result.Data.IdNumber);
  }
```

## Release Notes
### v1.0.0.17 
授权方式由 OAuth2 改为 请求签名鉴权

## 兼容性

|框架|最低支持版本|备注|
|:--:|:--:|:--:|
|.NET|5.0|
|.NET Core|2.0|
|.NET Framework|4.6.1|传统的.net框架，Windows Server 2016以上及Windows 10 1511以上已经自带|
|Mono|5.4|
|Xamarin.iOS|10.14|
|Xamarin.Max|3.8|
|Xamarin.Android|8.0|
|通用 Windows 平台|10.0.16299|
|Unity|2018.1|

## Reference

文档
https://open.esign.cn/doc/detail?id=opendoc%2Fpaas_api%2Fom5lm2&namespace=opendoc%2Fpaas_api
