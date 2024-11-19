using System;
using System.Collections.Generic;

namespace ESSMaterWebApp.Models;

public partial class DonationInterest
{
    public int DonationId { get; set; }

    public string FirstName { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string? AmountPledged { get; set; }

    public DateTime DateSubmitted { get; set; }
}
