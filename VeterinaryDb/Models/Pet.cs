using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VeterinaryDb.Models
{



    public class Pet
    {
        public int PetId { get; set; }
        public string PetName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Species { get; set; }
        public int OwnerId { get; set; }

        //Navigation Property

        public Owner Owner { get; set; }

       
    }
}

