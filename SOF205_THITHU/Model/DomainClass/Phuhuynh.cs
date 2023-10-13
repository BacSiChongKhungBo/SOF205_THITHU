using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SOF205_THITHU.Model.DomainClass;

[Table("PHUHUYNH")]
public partial class Phuhuynh
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("ten")]
    [StringLength(50)]
    public string Ten { get; set; } = null!;

    [Column("nghenghiep")]
    [StringLength(50)]
    public string? Nghenghiep { get; set; }

    [InverseProperty("IdPhNavigation")]
    public virtual ICollection<Sinhvien> Sinhviens { get; set; } = new List<Sinhvien>();
}
