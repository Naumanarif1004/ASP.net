using System;
using System.Collections.Generic;
using System.Text;

namespace BloodBank
{
    class DonationRecord : IDonationreacord
    {
        public DonationRecord(int do_id,int p_id,string p_name,int b_id,string b_group,string p_city,string dieses,DateTime date)
        {
            DonationId = do_id;
            PatientId = p_id;
            Patientname = p_name;
            BloodId = b_id;
            BloodGroup = b_group;
            PatientCity = p_city;
            PatientDieses = dieses;
            DonationDate = date;
        }
        public int DonationId { get; set ;}
        public int PatientId { get; set; }
        public string Patientname { get; set; }
        public int BloodId { get; set; }

        public string BloodGroup { get; set; }
        public string PatientCity { get; set; }
        public DateTime DonationDate { get; set; }
        public string PatientDieses { get; set; }

        public override string ToString()
        {
            return $"\nDonation ID::{DonationId}-----Blood Id::{BloodId}------Blood Group::{BloodGroup}------" +
                $"Patient Id::{PatientId }" +
                $"\nPatient Name::{Patientname}-----Patient Dieses Type::{PatientDieses}----" +
                $"Patient City::{PatientCity}----Donation Date::{DonationDate}";
        }
    }
}
