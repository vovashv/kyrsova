using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppKyrsova.EFContext
{
    [Table("tblAnswers")]
    public class Answers
    {
        [Key]
        public int Id { get; set; }
        public string Answer { get; set; }
    }
}
