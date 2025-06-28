using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BezorgApp.Data
{
    public class OrderDb
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string QrCode { get; set; }
        public string? Status { get; set; }
    }
}
