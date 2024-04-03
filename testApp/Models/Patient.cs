﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace testApp.Models
{
    [Table("patient")]
    public class Patient
        
    {
        [Key]
        public int patient_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int PESEL { get; set; }

        public Patient()
        {
            
        }
        public Patient(string firstName, string lastName, int pesel)
        {
            this.first_name = firstName;
            this.last_name = lastName;
            this.PESEL = pesel;
        }
    }
}
