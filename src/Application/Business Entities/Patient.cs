﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CIS.Application.Entities
{
    public class Patient : Person
    {
        public int Identifier { get; set; }
        public Hospital HospitalNumber { get; set; }
        public string OtherName { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string HomeAddress { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public string MiddleName { get; set; }
        public int MobilePhone { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PatientConsultant { get; set; }
        public string Nationality { get; set; }
        public string StateOfOrigin { get; set; }
        public string Hometown { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Religion { get; set; }
        public string Occupation { get; set; }
        public string OfficeAddress { get; set; }
        public string NationalIdType { get; set; }
        public string NationalIdNumber { get; set; }
        public string NextOfKin { get; set; }
        public string AddressNextOfKin { get; set; }
        public int PhoneNextOfKin { get; set; }
        public string EmailNextOfKin { get; set; }
        public string NextOfKinRelationship { get; set; }
        public string NameOfFather { get; set; }
        public string NameOfMother { get; set; }
        public HealthInsuranceProvider HealthInsuranceProvider { get; set; }
        public string DateAmended { get; set; }
        public byte[] Photo { get; set; }
    }
}
