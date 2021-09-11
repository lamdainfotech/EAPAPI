using System;
using System.ComponentModel.DataAnnotations;
using EAP.Shared.EntityFilterRepo;

namespace EAP.Shared.Dtos.Owners
{
    public class OwnerForUpdateDto : TEntity
    {
        public string Name { get; set; }
        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Address is required")]
        [StringLength(100, ErrorMessage = "Address can't be longer tha 100 character")]
        public string Address { get; set; }
        Guid TEntity.Id
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
    }
}