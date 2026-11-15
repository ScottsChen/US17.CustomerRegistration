
using System;
using System.Net.Mail;

namespace US17.CustomerRegistration.Domain;

 public class Customer
 {
     public Guid Id { get; private set; } = Guid.NewGuid();
     public string FirstName { get; private set; }
     public string LastName { get; private set; }
     public string Email { get; private set; }
     public string Phone { get; private set; }


     public Customer(string firstName, string lastName, string email, string phone)
        
     {

        if (string.IsNullOrWhiteSpace(firstName))
        {
            throw new ArgumentException("Förnamn måste anges.");

              
        }



        if (string.IsNullOrWhiteSpace(lastName))
        {
            throw new ArgumentException("Efternamn måste anges.");

        }

        if (string.IsNullOrWhiteSpace(email))
        {
            throw new ArgumentException("Email måste anges.");
        }


        if (string.IsNullOrWhiteSpace(phone))
        {
            throw new ArgumentException("Telefonnummer måste anges.");
        }

        if (!MailAddress.TryCreate(email, out _))
        {
            throw new ArgumentException("Ogiltigt e-postformat.");
        }




            FirstName = firstName.Trim();
            LastName = lastName.Trim();
            Email = email.Trim();
            Phone = phone.Trim();
     }



 }









