﻿namespace MyShop.WebApi.Data;

public partial class Customer : BaseEntity
{
    public string ApplicationUserId { get; set; }

    public long AddressId { get; set; }

    public long PhoneNumberId { get; set; }

    public Address Address { get; set; }

    public PhoneNumber PhoneNumber { get; set; }

    public virtual ApplicationUser ApplicationUser { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}