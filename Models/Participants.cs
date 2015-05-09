using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WoodlandsHOA_2.Models
{
    //adding information needed for the ParticipantDB


    [MetadataType(typeof(Participant))]
    public class Participant
    {
        public virtual int      ParticipantID   { get; set; }
        [Display (Name = "First Name")]
        public virtual string   firstName       { get; set; }
        [Display(Name = "Last Name")]
        public virtual string   lastName        { get; set; }
        [Display(Name = "Email Address")]
        public virtual string   emailAddress    { get; set; }
        [Display(Name = "Home Address")]
        public virtual string   homeAddress     { get; set; } 
    }
}