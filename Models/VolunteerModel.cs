﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VMS_SummerAssign.Models
{
    public class VolunteerModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [Display(Name ="First Name")]
        public string FName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        public string LName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Volunteer's Approval Status")]
        public string VolApprovStat { get; set; }

        [Required(ErrorMessage = "Please state whether you have a drivers license")]
        [Display(Name = "Driver's License")]
        public string DriversLicense { get; set; }

        [Required(ErrorMessage = "Please state what centers you would like to work for")]
        public String Centers { get; set; }

        [Required(ErrorMessage = "Please list your skills/interest")]
        public String Skills { get; set; }

        [Required(ErrorMessage = "Please state what times you are available")]
        [Display(Name = "Availabilty times")]
        public String AvailabilityTimes { get; set; }

        [Required(ErrorMessage = "Please give your current address")]
        [Display(Name = "Home Address")]
        public String HomeAddress { get; set; }

        [Required(ErrorMessage = "Please list the level of education received")]
        public String Education { get; set; }

        [Required(ErrorMessage = "Please list any licenses received")]
        public String Licenses { get; set; }

        [Required(ErrorMessage = "Please enter a emergency contact name")]
        [Display(Name = "Emergency Contact Name")]
        public String EmergContactName { get; set; }

        [Required(ErrorMessage = "Please enter a emergency contact number")]
        [Display(Name = "Emergency Contact Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public String EmergContactPhone { get; set; }

        [Required(ErrorMessage = "Please enter a emergency contact address")]
        [Display(Name = "Emergency Contact Address")]
        public String EmergContactAddress { get; set; }

        [Required(ErrorMessage = "Please state whether you have a social security card")]
        public String SocialSecurity { get; set; }

    }
}