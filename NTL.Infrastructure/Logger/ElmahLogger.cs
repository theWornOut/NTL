﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NTL.Infrastructure.Logger
{
    public class ElmahLogger
    {
        [Key]
        public Guid ErrorId { get; set; }

        [Required]
        [StringLength(60)]
        public string Application { get; set; }

        [Required]
        [StringLength(50)]
        public string Host { get; set; }

        [Required]
        [StringLength(100)]
        public string Type { get; set; }

        [Required]
        [StringLength(60)]
        public string Source { get; set; }

        [Required]
        [StringLength(500)]
        public string Message { get; set; }

        [Required]
        [StringLength(50)]
        public string User { get; set; }

        public int StatusCode { get; set; }

        public DateTime TimeUtc { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Sequence { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string AllXml { get; set; }
    }
}