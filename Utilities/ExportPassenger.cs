﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineLenz.Utilities
{
    public class ExportPassenger
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string PassportSeries { get; set; }
        public string PassportId { get; set; }
        public string DateOfIssue { get; set; }
        public string IssuedBy { get; set; }
    }
}
