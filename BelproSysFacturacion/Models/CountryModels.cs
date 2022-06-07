using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BelproSysFacturacion.Models
{
    public class CountryModels
    {

        [Key]
        [StringLength(3)]
        [Display(Name = "Código ISO País")]
        public String CountryISO { get; set; }

        [Required(ErrorMessage = "Ingrese el Nombre del País.")]
        [StringLength(200)]
        [Display(Name = "Nombre del País")]
        public string CountryName { get; set; }



        [Required]
        [Display(Name = "Código de País")]
        public ICollection<StateModel> StateModel { get; set; }



        [Required(ErrorMessage = "Ingresar el usuario que crea el registro.")]
        [StringLength(100)]
        [Display(Name = "Creado por")]
        public String UserEnrollmentInsert { get; set; }

        [Required(ErrorMessage = "Ingresar la Fecha de creado.")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Creado")]
        public System.DateTime EnrollmentDateInsert { get; set; }


        [Required(ErrorMessage = "Ingresar el usuario que modifico el registro.")]
        [StringLength(100)]
        [Display(Name = "Modificado por")]
        public String? UserEnrollmentModify { get; set; }


        [Required(ErrorMessage = "Ingresar la Fecha de Modificado.")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Modificado")]
        public System.DateTime EnrollmentDateModify { get; set; }




    }
}
