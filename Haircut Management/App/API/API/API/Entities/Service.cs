using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API.Entities;

public partial class Service
{
    /// <summary>
    /// Mã dịch vụ
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Tên dịch vụ
    /// </summary>
    [StringLength(50)]
    public string? Name { get; set; }

    /// <summary>
    /// Giá dịch vụ
    /// </summary>
    public int? Price { get; set; }

    /// <summary>
    /// Thời gian thực hiện (phút)
    /// </summary>
    public int? Duration { get; set; }

    [InverseProperty("Service")]
    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}
