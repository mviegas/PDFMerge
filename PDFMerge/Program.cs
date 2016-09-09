using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFMerge
{
    class Program
    {
        static void CopyPages(PdfDocument from, PdfDocument to)
        {
            for (int i = 0; i < from.PageCount; i++)
            {
                to.AddPage(from.Pages[i]);
            }
        }

        static void Main(string[] args)
        {
            var sourcePath1 = Console.ReadLine();
            var sourcePath2 = Console.ReadLine();

            using (PdfDocument one = PdfReader.Open(@"C:\Users\Mateus\Dropbox\Documentos\SETEMBRO-AMEX-EXTRATO.pdf", PdfDocumentOpenMode.Import))
            using (PdfDocument two = PdfReader.Open(@"C:\Users\Mateus\Dropbox\Documentos\SETEMBRO-AMEX-BOLETO.pdf", PdfDocumentOpenMode.Import))
            using (PdfDocument outPdf = new PdfDocument())
            {                
                CopyPages(one, outPdf);
                CopyPages(two, outPdf);

                outPdf.Save(@"C:\Users\Mateus\Desktop\SETEMBRO-AMEX.pdf");
            }
        }
    }
}
