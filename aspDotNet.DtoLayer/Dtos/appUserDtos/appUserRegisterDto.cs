using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aspDotNet.DtoLayer.Dtos.appUserDtos
{
    public class appUserRegisterDto
    {

       // [Required(ErrorMessage ="ad alani zorunludur")]
       // [Display(Name ="ad")]
       // [MaxLength(15,ErrorMessage ="En fazla 15 karakter girebilirsiniz")]

        public string dtoName { get; set; }

        public string dtoSurname{ get; set; }

        public string dtoEmail { get; set; }

        public string dtoUserName { get; set; }

        public string dtoPassword { get; set; }

        public string dtoConfirmPassword { get; set; }

        public int dtoDistrict {  get; set; }

        public int dtoCity { get; set; }
    }
}
