using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EAP.Entity.Models.Accounts;
using EAP.Shared.EntityFilterRepo;

namespace EAP.Entity.Models.Owners
{
    public class Owner : TEntity
    {
        [Column("OwnerId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name field is required")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 character")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Address is required")]
        [StringLength(100, ErrorMessage = "Address can't be longer tha 100 character")]
        public string Address { get; set; }
        public Account Acounts { get; set; }
    }
}