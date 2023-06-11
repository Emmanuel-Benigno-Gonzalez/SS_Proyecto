Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
'Imports WebGrease.Css
'Imports Microsoft.Win32
'Imports System.Windows.Forms


Public Class ProcesarPDF

    Private rutaDirectorio As String = "C:\\ReportesPDF"
    Private ruta As String = ""

    Public Sub CrearDirectorio()
        If (Directory.Exists(rutaDirectorio) = False) Then
            'MsgBox("El directorio ya existe")'
            My.Computer.FileSystem.CreateDirectory(rutaDirectorio)
        End If
    End Sub

    Public Function verificarArchivo(nombreArchivo)
        If (File.Exists(rutaDirectorio + "\\" + nombreArchivo + ".pdf")) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub obtenerRuta()


    End Sub


    Dim pdfDoc As New Document(iTextSharp.text.PageSize.A4, 15.0F, 15.0F, 30.0F, 30.0F)
    Dim pdfWrite As PdfWriter


    Public Sub reporteCliente(nombreArchivo)

        CrearDirectorio()
        ruta = rutaDirectorio + "\\" + nombreArchivo + ".pdf"

        If (verificarArchivo(nombreArchivo) = False) Then
            'MsgBox("El Archvo no existe")'
            'Definir el Archivo PDF
            pdfWrite = PdfWriter.GetInstance(pdfDoc, New FileStream(ruta, FileMode.Create))
            'Definir Tipografia'
            Dim Font8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL))
            Dim Font88 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD))
            Dim Font812 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.BOLD))
            'Definir un Salto de Linea o Celda (Fila) Vacia '
            Dim CVacio As PdfPCell = New PdfPCell(New Phrase(""))
            CVacio.Border = 0

            'Abrimos el archivo pdf'
            pdfDoc.Open()

            'Creamos una Tabla'
            Dim Table1 As PdfPTable = New PdfPTable(4)
            Dim Col1 As PdfPCell
            Dim Col2 As PdfPCell
            Dim Col3 As PdfPCell
            Dim Col4 As PdfPCell
            Dim Col5 As PdfPCell
            Dim Col6 As PdfPCell
            Dim ILine As Integer
            Dim IFila As Integer
            'Definir el Ancho de la Tabla (95%)'
            Table1.WidthPercentage = 95

            'Definir de forma proporcional el tamanio de cada Columna'
            Dim widths As Single() = New Single() {4.0F, 7.0F, 1.0F, 4.0F}
            Table1.SetWidths(widths)

            '*********************************ENCABEZADO*********************************'
            Dim imagenURL As String = "C:\Users\Emmanuel\source\repos\SS_PROYECTO\SS_PROYECTO\VistaForm\img\Inin.png"
            Dim imagenPDF As iTextSharp.text.Image
            imagenPDF = iTextSharp.text.Image.GetInstance(imagenURL)
            'imagenPDF.ScaleToFit(50, 50) 'Tamnio de la imagen'
            'imagenPDF.SpacingBefore = 20.0F
            'imagenPDF.SpacingAfter = 10.0F
            imagenPDF.ScaleAbsolute(50, 50)
            imagenPDF.SetAbsolutePosition(25, pdfDoc.PageSize.Height - 80) 'Posicion que ocupara la imagen'
            pdfDoc.Add(imagenPDF)

            'Fila 1'
            Table1.AddCell(CVacio) 'Celda que ocupara la imagen'
            Col2 = New PdfPCell(New Phrase("INSTITUTO NACIONAL DE INVESTIGACION NUCLEAR", Font88))
            Col2.Border = 0
            Table1.AddCell(Col2)
            Table1.AddCell(CVacio)
            Col3 = New PdfPCell(New Phrase("REPORTE DE CLIENTE", Font88))
            Col3.Border = 0
            Table1.AddCell(Col3)

            'Fila 2'
            Table1.AddCell(CVacio) 'Celda que ocupara la imagen'
            Col2 = New PdfPCell(New Phrase("CARR TOLUCA-MEXICO S/N, 52750, LA MARQUESA", Font8))
            Col2.Border = 0
            Table1.AddCell(Col2)
            Table1.AddCell(CVacio)
            Col3 = New PdfPCell(New Phrase("DOCIMETRÍA", Font88))
            Col3.Border = 0
            Table1.AddCell(Col3)

            'Fila 3'
            Table1.AddCell(CVacio) 'Celda que ocupara la imagen'
            Col2 = New PdfPCell(New Phrase("México", Font8))
            Col2.Border = 0
            Table1.AddCell(Col2)
            Table1.AddCell(CVacio)
            Col3 = New PdfPCell(New Phrase("", Font88))
            Col3.Border = 0
            Table1.AddCell(Col3)

            'Fila 4'
            Table1.AddCell(CVacio) 'Celda que ocupara la imagen'
            Col2 = New PdfPCell(New Phrase("55 5329 7200", Font8))
            Col2.Border = 0
            Table1.AddCell(Col2)
            Table1.AddCell(CVacio)
            Col3 = New PdfPCell(New Phrase("", Font88))
            Col3.Border = 0
            Table1.AddCell(Col3)

            'Fila 5'
            Table1.AddCell(CVacio) 'Celda que ocupara la imagen'
            Col2 = New PdfPCell(New Phrase("www.gob.mx/inin", Font8))
            Col2.Border = 0
            Table1.AddCell(Col2)
            Table1.AddCell(CVacio)
            Col3 = New PdfPCell(New Phrase("", Font88))
            Col3.Border = 0
            Table1.AddCell(Col3)

            'Agregar/Guardar Tabla 1'
            pdfDoc.Add(Table1)

            'Dibujar Cuadro'
            'PintaCuadro(0.7, 410, 740, 530, 820)
            'PintaLinea(0.5, 30, 733, 530, 733)
            'pdfDoc.Add(New Paragraph("."))

            '*********************************CONTENIDO*********************************'
            'Creamos una TablaContenido'
            Dim TableContenido As PdfPTable = New PdfPTable(3)
            Dim widthsContenido As Single() = New Single() {3.0F, 8.0F, 3.0F}
            TableContenido.WidthPercentage = 95
            TableContenido.SetWidths(widthsContenido)

            'Fila Salto (2) de Linea'
            TableContenido.AddCell(CVacio)
            TableContenido.AddCell(CVacio)
            TableContenido.AddCell(CVacio)
            TableContenido.AddCell(CVacio)
            TableContenido.AddCell(CVacio)
            TableContenido.AddCell(CVacio)

            'Fila Encabezado de la Tabla'
            Col1 = New PdfPCell(New Phrase("CLAVE CLIENTE", Font88))
            Col1.Border = 0
            TableContenido.AddCell(Col1)
            Col2 = New PdfPCell(New Phrase("NOMBRE", Font88))
            Col2.Border = 0
            TableContenido.AddCell(Col2)
            Col3 = New PdfPCell(New Phrase("DETALLE", Font88))
            Col3.Border = 0
            TableContenido.AddCell(Col3)

            Dim cv As New ModPOES
            Dim dt As DataTable = cv.ObtenerReporte()
            Dim dr As DataRow

            For Each dr In dt.Rows
                Col1 = New PdfPCell(New Phrase(dr.Item("CV_CLIENTE"), Font8))
                Col1.Border = 0
                TableContenido.AddCell(Col1)
                Col2 = New PdfPCell(New Phrase(dr.Item("NOMBRE_CLIENTE"), Font8))
                Col2.Border = 0
                TableContenido.AddCell(Col2)
                Col3 = New PdfPCell(New Phrase(dr.Item("NOMBRE_POE"), Font8))
                Col3.Border = 0
                TableContenido.AddCell(Col3)
            Next

            pdfDoc.Add(TableContenido)

            '*******************************PIE DE PAGINA*******************************'
            For IFila = 1 To 40
                pdfDoc.Add(New Paragraph("."))
                ILine = pdfWrite.GetVerticalPosition(True)
                If ILine < 200 Then
                    Exit For
                End If
            Next

            'Creamos una TablaFooter'
            Dim TableFooter As PdfPTable = New PdfPTable(5)
            Dim widthsFooter As Single() = New Single() {8.0F, 1.0F, 2.0F, 2.0F, 1.0F}
            TableFooter.WidthPercentage = 95
            TableFooter.SetWidths(widthsFooter)

            'Fila 1'
            Col1 = New PdfPCell(New Phrase("OBSERVACIONES", Font88))
            Col1.Border = 0
            TableFooter.AddCell(Col1)
            TableFooter.AddCell(CVacio)
            TableFooter.AddCell(CVacio)
            TableFooter.AddCell(CVacio)
            TableFooter.AddCell(CVacio)

            'Fila 2'
            Col1 = New PdfPCell(New Phrase("Sin Observaciones", Font88))
            Col1.Border = 0
            TableFooter.AddCell(Col1)
            TableFooter.AddCell(CVacio)
            TableFooter.AddCell(CVacio)
            TableFooter.AddCell(CVacio)
            TableFooter.AddCell(CVacio)

            'Fila 3'
            Col1 = New PdfPCell(New Phrase("", Font88))
            Col1.Border = 0
            TableFooter.AddCell(Col1)
            TableFooter.AddCell(CVacio)
            Col3 = New PdfPCell(New Phrase("1", Font88))
            Col3.Border = 0
            TableFooter.AddCell(Col3)
            TableFooter.AddCell(CVacio)
            TableFooter.AddCell(CVacio)

            pdfDoc.Add(TableFooter)

            'Cerrar el Documento PDF'
            pdfDoc.Close()
            MsgBox("EL DOCUMENTO SE CREO EXITOSAMENTE")

            'Abrir el Documento'
            Process.Start(ruta)

        Else
            MsgBox("El Archivo ya existe")
        End If

    End Sub

    Public Sub reportePoe(nombreArchivo)

        CrearDirectorio()
        ruta = rutaDirectorio + "\\" + nombreArchivo + ".pdf"

        If (verificarArchivo(nombreArchivo) = False) Then
            'MsgBox("El Archvo no existe")'
            'Definir el Archivo PDF
            pdfWrite = PdfWriter.GetInstance(pdfDoc, New FileStream(ruta, FileMode.Create))
            'Definir Tipografia'
            Dim Font8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL))
            Dim Font88 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD))
            Dim Font812 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.BOLD))
            'Definir un Salto de Linea o Celda (Fila) Vacia '
            Dim CVacio As PdfPCell = New PdfPCell(New Phrase(""))
            CVacio.Border = 0

            'Abrimos el archivo pdf'
            pdfDoc.Open()

            'Creamos una Tabla'
            Dim Table1 As PdfPTable = New PdfPTable(4)
            Dim Col1 As PdfPCell
            Dim Col2 As PdfPCell
            Dim Col3 As PdfPCell
            Dim Col4 As PdfPCell
            Dim Col5 As PdfPCell
            Dim Col6 As PdfPCell
            Dim ILine As Integer
            Dim IFila As Integer
            'Definir el Ancho de la Tabla (95%)'
            Table1.WidthPercentage = 95

            'Definir de forma proporcional el tamanio de cada Columna'
            Dim widths As Single() = New Single() {4.0F, 7.0F, 1.0F, 4.0F}
            Table1.SetWidths(widths)

            '*********************************ENCABEZADO*********************************'
            Dim imagenURL As String = "C:\Users\Emmanuel\source\repos\SS_PROYECTO\SS_PROYECTO\VistaForm\img\Inin.png"
            Dim imagenPDF As iTextSharp.text.Image
            imagenPDF = iTextSharp.text.Image.GetInstance(imagenURL)
            'imagenPDF.ScaleToFit(50, 50) 'Tamnio de la imagen'
            'imagenPDF.SpacingBefore = 20.0F
            'imagenPDF.SpacingAfter = 10.0F
            imagenPDF.ScaleAbsolute(50, 50)
            imagenPDF.SetAbsolutePosition(25, pdfDoc.PageSize.Height - 80) 'Posicion que ocupara la imagen'
            pdfDoc.Add(imagenPDF)

            'Fila 1'
            Table1.AddCell(CVacio) 'Celda que ocupara la imagen'
            Col2 = New PdfPCell(New Phrase("INSTITUTO NACIONAL DE INVESTIGACION NUCLEAR", Font88))
            Col2.Border = 0
            Table1.AddCell(Col2)
            Table1.AddCell(CVacio)
            Col3 = New PdfPCell(New Phrase("REPORTE DE CLIENTE", Font88))
            Col3.Border = 0
            Table1.AddCell(Col3)

            'Fila 2'
            Table1.AddCell(CVacio) 'Celda que ocupara la imagen'
            Col2 = New PdfPCell(New Phrase("CARR TOLUCA-MEXICO S/N, 52750, LA MARQUESA", Font8))
            Col2.Border = 0
            Table1.AddCell(Col2)
            Table1.AddCell(CVacio)
            Col3 = New PdfPCell(New Phrase("DOCIMETRÍA", Font88))
            Col3.Border = 0
            Table1.AddCell(Col3)

            'Fila 3'
            Table1.AddCell(CVacio) 'Celda que ocupara la imagen'
            Col2 = New PdfPCell(New Phrase("México", Font8))
            Col2.Border = 0
            Table1.AddCell(Col2)
            Table1.AddCell(CVacio)
            Col3 = New PdfPCell(New Phrase("", Font88))
            Col3.Border = 0
            Table1.AddCell(Col3)

            'Fila 4'
            Table1.AddCell(CVacio) 'Celda que ocupara la imagen'
            Col2 = New PdfPCell(New Phrase("55 5329 7200", Font8))
            Col2.Border = 0
            Table1.AddCell(Col2)
            Table1.AddCell(CVacio)
            Col3 = New PdfPCell(New Phrase("", Font88))
            Col3.Border = 0
            Table1.AddCell(Col3)

            'Fila 5'
            Table1.AddCell(CVacio) 'Celda que ocupara la imagen'
            Col2 = New PdfPCell(New Phrase("www.gob.mx/inin", Font8))
            Col2.Border = 0
            Table1.AddCell(Col2)
            Table1.AddCell(CVacio)
            Col3 = New PdfPCell(New Phrase("", Font88))
            Col3.Border = 0
            Table1.AddCell(Col3)

            'Agregar/Guardar Tabla 1'
            pdfDoc.Add(Table1)

            'Dibujar Cuadro'
            'PintaCuadro(0.7, 410, 740, 530, 820)
            'PintaLinea(0.5, 30, 733, 530, 733)
            'pdfDoc.Add(New Paragraph("."))

            '*********************************CONTENIDO*********************************'
            'Creamos una TablaContenido'
            Dim TableContenido As PdfPTable = New PdfPTable(2)
            Dim widthsContenido As Single() = New Single() {6.0F, 8.0F}
            TableContenido.WidthPercentage = 95
            TableContenido.SetWidths(widthsContenido)

            'Fila Salto (2) de Linea'
            TableContenido.AddCell(CVacio)
            TableContenido.AddCell(CVacio)
            TableContenido.AddCell(CVacio)
            TableContenido.AddCell(CVacio)

            'Fila Encabezado de la Tabla'
            Col1 = New PdfPCell(New Phrase("CLIENTE", Font88))
            Col1.Border = 0
            TableContenido.AddCell(Col1)
            Col2 = New PdfPCell(New Phrase("POE", Font88))
            Col2.Border = 0
            TableContenido.AddCell(Col2)

            Dim cv As New ModPOES
            Dim dt As DataTable = cv.ObtenerReporte()
            Dim dr As DataRow

            For Each dr In dt.Rows
                Col1 = New PdfPCell(New Phrase(dr.Item("NOMBRE_CLIENTE"), Font8))
                Col1.Border = 0
                TableContenido.AddCell(Col1)
                Col2 = New PdfPCell(New Phrase(dr.Item("NOMBRE_POE"), Font8))
                Col2.Border = 0
                TableContenido.AddCell(Col2)
            Next

            pdfDoc.Add(TableContenido)

            '*******************************PIE DE PAGINA*******************************'
            For IFila = 1 To 40
                pdfDoc.Add(New Paragraph("."))
                ILine = pdfWrite.GetVerticalPosition(True)
                If ILine < 200 Then
                    Exit For
                End If
            Next

            'Creamos una TablaFooter'
            Dim TableFooter As PdfPTable = New PdfPTable(5)
            Dim widthsFooter As Single() = New Single() {8.0F, 1.0F, 2.0F, 2.0F, 1.0F}
            TableFooter.WidthPercentage = 95
            TableFooter.SetWidths(widthsFooter)

            'Fila 1'
            Col1 = New PdfPCell(New Phrase("OBSERVACIONES", Font88))
            Col1.Border = 0
            TableFooter.AddCell(Col1)
            TableFooter.AddCell(CVacio)
            TableFooter.AddCell(CVacio)
            TableFooter.AddCell(CVacio)
            TableFooter.AddCell(CVacio)

            'Fila 2'
            Col1 = New PdfPCell(New Phrase("Sin Observaciones", Font88))
            Col1.Border = 0
            TableFooter.AddCell(Col1)
            TableFooter.AddCell(CVacio)
            TableFooter.AddCell(CVacio)
            TableFooter.AddCell(CVacio)
            TableFooter.AddCell(CVacio)

            'Fila 3'
            Col1 = New PdfPCell(New Phrase("", Font88))
            Col1.Border = 0
            TableFooter.AddCell(Col1)
            TableFooter.AddCell(CVacio)
            Col3 = New PdfPCell(New Phrase("1", Font88))
            Col3.Border = 0
            TableFooter.AddCell(Col3)
            TableFooter.AddCell(CVacio)
            TableFooter.AddCell(CVacio)

            pdfDoc.Add(TableFooter)

            'Cerrar el Documento PDF'
            pdfDoc.Close()
            MsgBox("EL DOCUMENTO SE CREO EXITOSAMENTE")

            'Abrir el Documento'
            Process.Start(ruta)

        Else
            MsgBox("El Archivo ya existe")
        End If

    End Sub

End Class
