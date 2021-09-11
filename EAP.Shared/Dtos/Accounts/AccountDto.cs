using System;
using System.ComponentModel.DataAnnotations;

namespace EAP.Shared.Dtos.Accounts
{
    public class AccountDto
    {
        public Guid AccountId { get; set; }
        [Required(ErrorMessage = "Date Created is required")]
        public DateTime CreatedDate { get; set; }
        [Required(ErrorMessage = "Account type is required")]
        [StringLength(50, ErrorMessage = "Account Type can't be longer than 100 character")]
        public string AccountType { get; set; }
    }
}