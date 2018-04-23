using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace T530023.Models
{
    public class CustomUploadControlValidationSettings
    {
        public static UploadControlValidationSettings Settings = new UploadControlValidationSettings()
        {
            AllowedFileExtensions = new string[] { ".rtf", ".docx" },
            MaxFileSize = 4194304
        };
    }
}