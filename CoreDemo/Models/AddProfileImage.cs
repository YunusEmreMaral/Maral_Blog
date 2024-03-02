using Microsoft.AspNetCore.Http;
using System;

namespace CoreDemo.Models
{
    public class AddProfileImage
    { 
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public IFormFile WriterImage { get; set; } // dosyadan veri secme  +  model kullanımı //
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public string WriterPassword2 { get; set; }
        public bool WriterStatus { get; set; }
    }
}
