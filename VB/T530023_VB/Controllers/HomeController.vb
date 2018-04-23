Imports System.Web.Mvc
Imports DevExpress.Web
Imports DevExpress.Web.Mvc
Imports T530023_VB

Public Class HomeController
    Inherits Controller

    Public Function Index() As ActionResult
        Return View()
    End Function

    Public Function UploadControlUpload() As ActionResult
        Dim errors As String()

        Dim files As UploadedFile() = UploadControlExtension.GetUploadedFiles("UploadControl", CustomUploadControlValidationSettings.Settings, errors, AddressOf UploadControl_FileUploadComplete, AddressOf UploadControl_FilesUploadComplete)

        Return Nothing
    End Function

    Public Sub UploadControl_FileUploadComplete(sender As Object, e As FileUploadCompleteEventArgs)

    End Sub

    Public Sub UploadControl_FilesUploadComplete(sender As Object, e As FilesUploadCompleteEventArgs)
        Dim files As UploadedFile() = DirectCast(sender, MVCxUploadControl).UploadedFiles
        For i As Integer = 0 To files.Length - 1
            If files(i).IsValid AndAlso Not String.IsNullOrWhiteSpace(files(i).FileName) Then
                Dim resultFilePath As String = "~/Content/" + files(i).FileName
                files(i).SaveAs(System.Web.HttpContext.Current.Request.MapPath(resultFilePath))

                Dim urlResolver As IUrlResolutionService = TryCast(sender, IUrlResolutionService)
                If urlResolver IsNot Nothing Then
                    e.CallbackData += urlResolver.ResolveClientUrl(resultFilePath)
                End If
            End If
        Next
    End Sub

    Public Function RichEditPartial(path As String) As ActionResult
        ViewData("path") = path
        Return PartialView("_RichEditPartial")
    End Function

    Public Function CallbackPanelPartial(path As String) As ActionResult
        ViewData("path") = path
        Return PartialView("_CallbackPanelPartial")
    End Function
End Class