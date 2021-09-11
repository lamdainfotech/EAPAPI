using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EAP.Entity.Models.Owners;

namespace EAP.Entity.Models.Accounts
{
    public class Account
    {
        public Guid AccountId { get; set; }
        [Required(ErrorMessage = "Date Created is required")]
        public DateTime CreatedDate { get; set; }
        [Required(ErrorMessage = "Account type is required")]
        [StringLength(50, ErrorMessage = "Account Type can't be longer than 100 character")]
        public string AccountType { get; set; }
        [ForeignKey(nameof(Owner))]
        public Guid OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}