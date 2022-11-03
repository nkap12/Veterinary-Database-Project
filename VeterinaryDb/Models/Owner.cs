using System;
namespace VeterinaryDb.Models
{

    public class Owner
    {
        public int OwnerId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Address { get; set; }
       
    
        //Relationships
        public ICollection<Pet>? Pet { get; set; } = null!;
    }
    
}

