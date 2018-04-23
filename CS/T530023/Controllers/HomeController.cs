using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using DevExpress.Web;
using System.Web.UI;
using T530023.Models;

namespace T530023.Controllers
{
    public class HomeController : Controller
    {
   
        public ActionResult Index() {
            return View();
        }

        public ActionResult UploadControlUpload() {
            string[] errors;

            UploadedFile[] files = UploadControlExtension.GetUploadedFiles("UploadControl",
                CustomUploadControlValidationSettings.Settings, out errors,
                UploadControl_FileUploadComplete,
                UploadControl_FilesUploadComplete);

            return null;
        }

        public void UploadControl_FileUploadComplete(object sender, FileUploadCompleteEventArgs e) {

        }

        public void UploadControl_FilesUploadComplete(object sender, FilesUploadCompleteEventArgs e) {
            UploadedFile[] files = ((MVCxUploadControl)sender).UploadedFiles;
            for (int i = 0; i < files.Length; i++) {
                if (files[i].IsValid && !string.IsNullOrWhiteSpace(files[i].FileName)) {
                    string resultFilePath = "~/Content/" + files[i].FileName;
                    files[i].SaveAs(System.Web.HttpContext.Current.Request.MapPath(resultFilePath));

                    IUrlResolutionService urlResolver = sender as IUrlResolutionService;
                    if (urlResolver != null)
                        e.CallbackData += urlResolver.ResolveClientUrl(resultFilePath);
                }
            }
        }

        public ActionResult RichEditPartial(string path) {
            ViewData["path"] = path;
            return PartialView("_RichEditPartial");
        }

        public ActionResult CallbackPanelPartial(string path) {
            ViewData["path"] = path;
            return PartialView("_CallbackPanelPartial");
        }
    }
}
