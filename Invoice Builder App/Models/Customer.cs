using System.ComponentModel.DataAnnotations;

namespace Invoice_Builder_App.Models;

public class Customer
{
    public Guid Id { get; set; }

    [EmailAddress]
    public string Email { get; set; }

    public string PostalCode { get; set; }

    public TaxInfo Tax { get; set; }

    public string Address { get; set; }

    public UserInfo User { get; set; }

    public string BankDetails { get; set; }
}
