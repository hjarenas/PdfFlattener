// See https://aka.ms/new-console-template for more information
using iText.Forms;
using iText.Kernel.Pdf;
var inputFilePath = @""; // replace with the path to the input pdf
var outputFilePath = @""; // replace with the path where the flattened pdf should be saved to
var pdfFile = File.OpenRead(inputFilePath);
var reader = new PdfReader(pdfFile);
var pdfWriter = new PdfWriter(outputFilePath);
var pdfDoc = new PdfDocument(reader, pdfWriter);
var acroForm = PdfAcroForm.GetAcroForm(pdfDoc, false);
acroForm.FlattenFields();
pdfDoc.Close();