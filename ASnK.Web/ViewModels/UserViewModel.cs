using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ASnK.Data;

namespace ASnK.Web.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public UserViewModel()
        {
            ArrivalDate = DateTime.Today.ToUniversalTime();
            RegistrationDate = DateTime.Today.ToUniversalTime();
            ArrivalTime = DateTime.Now.ToUniversalTime().TimeOfDay;
            Events = new List<tbl_Events>();
        }

        [Display(Name = "First name")]
        [DataType(DataType.Text)]
        [Required(AllowEmptyStrings = false, ErrorMessage ="First name is required")]
        public string Firstname { get; set; }

        [Display(Name = "Last name")]
        [DataType(DataType.Text)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last name is required")]
        public string Lastname { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Display(Name = "Country")]
        [DataType(DataType.Text)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Country is required")]
        public string Country { get; set; }

        public int EventId { get; set; }

        [Display(Name = "Arrival Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ArrivalDate { get; set; }

        [Display(Name = "Arrival time")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh\\:mm}")]
        [DataType(DataType.Time)]
        public TimeSpan ArrivalTime { get; set; }

        [Display(Name = "Registration Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RegistrationDate { get; set; }

        public IList<tbl_Events> Events { get; internal set; }
    }
}
