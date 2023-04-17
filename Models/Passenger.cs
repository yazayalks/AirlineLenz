using DocumentFormat.OpenXml.Bibliography;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineLenz.Models
{
    public class Passenger
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public int PassportSeries { get; set; }
        public int PassportId { get; set; }
        public DateTime DateOfIssue { get; set; }
        public string IssuedBy { get; set; }

    }
}
