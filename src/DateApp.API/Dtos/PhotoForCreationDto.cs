using System;
using Microsoft.AspNetCore.Http;

namespace DateApp.API.Dtos
{
    public class PhotoForCreationDto
    {
        public PhotoForCreationDto()
        {
            this.DateAdded = DateTime.Now;
        }
        public string Url { get; set; }
        public IFormFile File { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public string PublicId { get; set; }
    }
}