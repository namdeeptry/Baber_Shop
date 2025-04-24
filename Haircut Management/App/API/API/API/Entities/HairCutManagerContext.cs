using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API.Entities;

public partial class HairCutManagerContext : DbContext
{
    public HairCutManagerContext()
    {
    }

    public HairCutManagerContext(DbContextOptions<HairCutManagerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<Staff> Staffs { get; set; }

}
