﻿using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BezorgApp.MVVM.Model
{
    [Table("order")]
    public class Order
    {
        //    public Order(int id, string? name, string qrCode, string? status)
        //    {
        //        Id = id;
        //        Name = name;
        //        QrCode = qrCode;
        //        Status = status;
        //    }

        //    [Required]
        //    public int Id { get; set; }
        //    [Required]
        //    public string? Name { get; set; }
        //    [Required]
        //    public string? QrCode { get; set; }
        //    [Required]
        //    public string? Status { get; set; }

        [PrimaryKey]
        [AutoIncrement]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string? Name { get; set; }
        [Column("qrcode")]
        public string? QrCode { get; set; }
        [Column("status")]
        public string? Status { get; set; }
    }
}
