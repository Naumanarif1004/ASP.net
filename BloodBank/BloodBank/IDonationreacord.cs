using System;
using System.Collections.Generic;
using System.Text;

namespace BloodBank
{
    public interface IDonationreacord
    {
        int DonationId { get; set; }
        int PatientId { get; set; }
        string Patientname { get; set; }
        int BloodId { set; get; }
        string BloodGroup { get; set; }
        string PatientCity { get; set; }
        DateTime DonationDate { get; set; }
        string PatientDieses { get; set; }
    }
}
