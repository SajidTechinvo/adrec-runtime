using Runtime.DTO.ApiModels.Common;
using System.ComponentModel.DataAnnotations;

namespace Runtime.DTO.ApiModels.DMTModel
{
    public class UploadFileRequest
    {
        public string Name { get; set; }

        [Required(ErrorMessage = "File is required")]
        public FileRequestModel File { get; set; }
    }
}