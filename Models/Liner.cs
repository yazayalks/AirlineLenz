using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineLenz.Models
{
     public class Liner
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime InspectionDate { get; set; }
        public DateTime DateOfIssue { get; set; }
        public string Photo { get; set; }
        public LinerType LinerType { get; set; }
    }
}
