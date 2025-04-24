using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API.Entities;

public partial class Staff
{
    /// <summary>
    /// Mã nhân viên
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Tên nhân viên
    /// </summary>
    [StringLength(100)]
    public string? Name { get; set; }

    /// <summary>
    /// Chức vụ (Thợ cắt, Lễ tân, Quản lý)
    /// </summary>
    [StringLength(50)]
    public string? Role { get; set; }

    /// <summary>
    /// Ca làm việc
    /// </summary>
    [StringLength(50)]
    public string? WorkingHours { get; set; }

    [InverseProperty("Staff")]
    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}
