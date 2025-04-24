using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API.Entities;

public partial class Appointment
{
    /// <summary>
    /// Mã lịch hẹn
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Mã khách hàng
    /// </summary>
    public int? CustomerId { get; set; }

    /// <summary>
    /// Mã dịch vụ
    /// </summary>
    public int? ServiceId { get; set; }

    /// <summary>
    /// Mã nhân viên thực hiện
    /// </summary>
    public int? StaffId { get; set; }

    /// <summary>
    /// Ngày giờ hẹn
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? DateTime { get; set; }

    /// <summary>
    /// Trạng thái (Pending/Completed/Cancelled)
    /// </summary>
    [StringLength(50)]
    public string? Status { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("Appointments")]
    public virtual Customer? Customer { get; set; }

    [InverseProperty("Appointment")]
    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    [ForeignKey("ServiceId")]
    [InverseProperty("Appointments")]
    public virtual Service? Service { get; set; }

    [ForeignKey("StaffId")]
    [InverseProperty("Appointments")]
    public virtual Staff? Staff { get; set; }
}
