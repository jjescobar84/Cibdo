using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Cibdo.Models
{
    public class Reminder
    {
        #region Parámetros

        [Key]
        public int recordatorioId { get; set; }
        
        [Required(ErrorMessage= "the fild {0} is required")]
        [StringLength(50, ErrorMessage= "The fild {0} can contain maximun {1} and minimun {2} caracters", MinimumLength=3)]
        public string nombre { get; set; }
       
        [Required(ErrorMessage = "the fild {0} is required")]
        public int tipoRecordatorioId { get; set; }
        
        [Required(ErrorMessage = "the fild {0} is required")]
        [StringLength(200, ErrorMessage = "The fild {0} can contain maximun {1} and minimun {2} caracters", MinimumLength = 3)]
        [DataType(DataType.MultilineText)]
        public string descripcion { get; set; }
        
        [Required(ErrorMessage = "the fild {0} is required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode= true)]
        public DateTime fecha { get; set; }
       
        [Required(ErrorMessage = "the fild {0} is required")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime hora { get; set; }
        
        // Relacion con los tipos de recordatorio (Lado muchos)

        public virtual   ReminderType ReminderType{ get; set; }

        #endregion
    }
}