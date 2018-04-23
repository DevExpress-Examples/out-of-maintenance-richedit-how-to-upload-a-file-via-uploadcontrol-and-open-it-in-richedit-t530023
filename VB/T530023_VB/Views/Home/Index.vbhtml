@Using Html.BeginForm("UploadControlForm", "Home", FormMethod.Post)
    @Html.DevExpress().UploadControl(
     Sub(settings)
         settings.Name = "UploadControl"
         settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "UploadControlUpload"}
         settings.ShowUploadButton = True
         settings.ShowProgressPanel = True
         settings.UploadMode = UploadControlUploadMode.Standard
         settings.ValidationSettings.Assign(T530023_VB.CustomUploadControlValidationSettings.Settings)
         settings.ClientSideEvents.FilesUploadComplete = "function(s, e) { CallbackPanel.PerformCallback( { path: e.callbackData }); }"
     End Sub).GetHtml()
End Using
<br/>
@Html.Action("CallbackPanelPartial")

