using System;
using System.Collections.Generic;

namespace ESSMaterWebApp.Models;

public partial class Appointment
{
    public int AppointmentId { get; set; }

    public string ServiceType { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string Province { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Suburb { get; set; } = null!;

    public DateTime SubmissionDate { get; set; }

    public DateTime AppointmentDate { get; set; }
}
