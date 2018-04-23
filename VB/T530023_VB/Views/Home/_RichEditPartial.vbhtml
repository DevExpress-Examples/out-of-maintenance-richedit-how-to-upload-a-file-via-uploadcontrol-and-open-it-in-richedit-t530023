
@Code
    Dim editor = Html.DevExpress().RichEdit(Sub(settings)
                                                    settings.Name = "RichEdit"
                                                    settings.CallbackRouteValues = New With { _
                                                        Key .Controller = "Home", _
                                                        Key .Action = "RichEditPartial" _
                                                    }

                                            End Sub)

    If ViewData("path") IsNot Nothing Then
        editor.Open(Server.MapPath(ViewData("path").ToString()))
    End If
End code
@editor.GetHtml()