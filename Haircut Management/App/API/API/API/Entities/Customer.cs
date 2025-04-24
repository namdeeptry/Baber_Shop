using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API.Entities;

public partial class Customer
{
    /// <summary>
    /// Mã khách hàng
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Tên khách hàng
    /// </summary>
    [StringLength(100)]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Số điện thoại
    /// </summary>
    [StringLength(50)]
    public string? Phone { get; set; }

    /// <summary>
    /// Ngày sinh
    /// </summary>
    public DateOnly? BirthDate { get; set; }

    /// <summary>
    /// Ngày tạo
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? CreateAt { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}
