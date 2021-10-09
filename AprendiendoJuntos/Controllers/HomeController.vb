Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Bienvenido."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Contactenos estamos para servirle."

        Return View()
    End Function
End Class
