using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BelproSysFacturacion.Models
{
    public class CountyModels
    {
        [Key]
        [Column("IdCounty")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingresar la Descripción del Municipio")]
        [StringLength(100)]
        [Display(Name = "Descripción del Municipio")]
        public String CountyDescrip { get; set; }

        [Required(ErrorMessage = "Ingresar el usuario que crea el registro.")]
        [StringLength(100)]
        [Display(Name = "Creado por")]
        public String UserEnrollmentInsert { get; set; }


        [Required(ErrorMessage = "Ingresar la Fecha de creado del tipo de cliente.")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Creado")]
        public System.DateTime EnrollmentDateInsert { get; set; }


        [Required(ErrorMessage = "Ingresar el usuario que modifico el registro.")]
        [StringLength(100)]
        [Display(Name = "Modificado por")]
        public String UserEnrollmentModify { get; set; }


        [Required(ErrorMessage = "Ingresar la Fecha de Modificado del tipo de cliente.")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Modificado")]
        public System.DateTime EnrollmentDateModify { get; set; }


    }
}
