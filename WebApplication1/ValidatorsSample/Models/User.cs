using FluentValidation.Attributes;
using System;

namespace WebApiValidationDemo.Mvc.Lib.Models
{
    [Validator(typeof(UserValidator))]
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Username { get; set; }
    }
}