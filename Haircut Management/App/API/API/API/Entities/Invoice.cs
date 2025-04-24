using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API.Entities;

public partial class Invoice
{
    /// <summary>
    /// Mã hóa đơn
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Mã lịch hẹn
    /// </summary>
    public int? AppointmentId { get; set; }

    /// <summary>
    /// Tổng tiền
    /// </summary>
    public int? TotalPrice { get; set; }

    /// <summary>
    /// Ngày tạo hóa đơn
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [ForeignKey("AppointmentId")]
    [InverseProperty("Invoices")]
    public virtual Appointment? Appointment { get; set; }
}
