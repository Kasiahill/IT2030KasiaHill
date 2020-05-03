Imports System.Web.Mvc

Namespace Controllers
    Public Class StoreController
        Inherits Controller

        ' GET: Store
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace