using BankApp.Implementations;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApps.Test
{
    public class ValidationShould
    {
        [Test]
        public void CheckValidateName()
        {
            string name = "Gbadamosi Idowu";
            var valid = new Validation();
            var result = valid.ValidateName(name);
            Assert.That(result, Is.True);   
        }
        [Test]
        public void CheckValidateEmail()
        {
            string Email = "gbadamosi@gmail.com";
            var valid = new Validation();
            var result = valid.ValidateEmail(Email);
            Assert.That(result, Is.True);
        }
        [Test]
        public void CheckValidatePassword()
        {
            string password = "Gbadamosi Idowu";
            var valid = new Validation();
            var result = valid.ValidatePassword(password);
            Assert.That(result, Is.Not.True);
        }
    }
}
