using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EAP.Shared.Dtos.Accounts;
using EAP.Shared.EntityFilterRepo;

namespace EAP.Shared.Dtos.Owners
{
    public class OwnerCreateDto : TEntity
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name can't be longer tha 100 character")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Address is required")]
        [StringLength(100, ErrorMessage = "Address can't be longer tha 100 character")]
        public string Address { get; set; }
        public AccountDto Accounts { get; set; }
    }
}