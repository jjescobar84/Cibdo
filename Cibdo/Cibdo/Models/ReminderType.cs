using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Cibdo.Models
{
    public class ReminderType
    {
        #region parámetros
        [Key]
        public int tipoRecordatorioId { get; set; }
        [Required(ErrorMessage="The fild {0} is required")]
        [StringLength(50, ErrorMessage = "The fild {0} can contain maximun {1} and minimun {2} caracters", MinimumLength = 3)]
        [Display(Name="Tipo")]
        public string nombre { get; set; }

        // Relacion del lado uno con los recordatorios 
        public virtual ICollection<Reminder> Reminders { get; set; }
        #endregion
    }
}