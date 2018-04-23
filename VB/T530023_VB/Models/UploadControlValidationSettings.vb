Imports DevExpress.Web

Public Class CustomUploadControlValidationSettings
    Public Shared Settings As New UploadControlValidationSettings() With {
         .AllowedFileExtensions = New String() {".rtf", ".docx"},
         .MaxFileSize = 4194304
    }
End Class
