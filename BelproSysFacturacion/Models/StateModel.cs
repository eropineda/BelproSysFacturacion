using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BelproSysFacturacion.Models
{
    public class StateModel
    {
        [Key]
        [StringLength(3)]
        [Display(Name = "Código Departamento")]
        public int StateISO { get; set; }
        [Required]
        [StringLength(3)]
        [Display(Name = "Código Secundario Departamento")]
        public string StateSecundaryCodeISO { get; set; }


        [Required]
        [StringLength(150)]
        [Display(Name = "Código Secundario Departamento")]
        public string StateDescrip { get; set; }

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
        public String UserEnrollmentModify { get; set; }


        [Required(ErrorMessage = "Ingresar la Fecha de Modificado.")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Modificado")]
        public System.DateTime EnrollmentDateModify { get; set; }
    }
}
