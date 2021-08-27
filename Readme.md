<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128553227/16.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T530023)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/T530023/Controllers/HomeController.cs)
* [UploadControlValidationSettings.cs](./CS/T530023/Models/UploadControlValidationSettings.cs)
* [_CallbackPanelPartial.cshtml](./CS/T530023/Views/Home/_CallbackPanelPartial.cshtml)
* [_RichEditPartial.cshtml](./CS/T530023/Views/Home/_RichEditPartial.cshtml)
* **[Index.cshtml](./CS/T530023/Views/Home/Index.cshtml)**
<!-- default file list end -->
# RichEdit - How to upload a file via UploadControl and open it in RichEdit


This example demonstrates how to upload a document by using our UploadControl and show this file content in RichEdit once it's uploaded.<br><br>To accomplish such a task, put the RichEdit extension in the <a href="https://documentation.devexpress.com/#AspNet/CustomDocument9000">CallbackPanel</a> container and use its callbacks to open the uploaded file by using the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebMvcRichEditExtension_Opentopic">RichEditExtension.Open</a> method.

<br/>


