using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelectPdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Model;
//https://www.youtube.com/watch?v=tjGXcSFVGGc&t=539s
namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HTMLPDFController : ControllerBase
    {
        [HttpGet]
        public dynamic GetPDFTOHTML(ModelClass obj)
        {
            HtmlToPdf converter = new HtmlToPdf();
            PdfDocument doc = converter.ConvertUrl("file:///C:/Users/Hp/Desktop/index.html");
            doc.Save($@"{AppDomain.CurrentDomain.BaseDirectory}\url.pdf");
            doc.Close();
            return Ok();

            //---------Need to convert JSON Stringify
            //PdfDocument doc = converter.ConvertHtmlString(obj.stringData);
            //byte[] pdffile = doc.Save();
            //doc.Close();  
            //string base64String = Convert.ToBase64String(pdffile, 0, pdffile.Length);
            //return Ok(base64String);



        }
    }
}
