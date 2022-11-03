using BankApp.Data;
using BankApp.Implementations;
using BankApp.Models;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApps.Test
{
    
    public class CustomerDataShould
    {
        
        [Test]
        public void CheckAddCustomer()
        {
            var customer = new CustomerModel()
            {
                Name = "Gbada Idowu",
                Email = "samuels@gmail.com",
                Password = "abcdef123!",
                UserId = 2
            };
            var sut = new CustomerData();
            var result = sut.AddCustomer(customer);
            Assert.That(result, Is.True);
        }
        [Test]
        public void CheckGetAllCustomer()
        {
            var systemUnderTest = new CustomerData();
            var result = systemUnderTest.GetAllCustomer();
            Assert.That(result, Is.Not.Empty);
        }
        [Test]
        public void CheckLastId()
        {
            var systemUnderTest = new CustomerData();
            var result = systemUnderTest.LastId();
            Assert.That(result, Is.GreaterThan(0));
        }
        [Test]
        public void CheckGetCustomerByEmail()
        {
            var customer = new CustomerModel
            {
                UserId=1,
                Name = "Abiodun Kazeem",
                Email = "harbbey@gmail.com",
                Password = "def234!"
            };
            var systemUnderTest = new CustomerData();
            systemUnderTest.AddCustomer(customer);
            var result = systemUnderTest.GetCustomerByEmail("harbbey@gmail.com");
            Assert.That(result.Name,Is.EqualTo("Abiodun Kazeem"));
        }
        [Test]
        public void CheckGetCustomerById()
        {
            var customer = new CustomerModel
            {
                UserId = 1,
                Name = "Abiodun Kazeem",
                Email = "harbbey@gmail.com",
                Password = "def234!"
            };
            var systemUnderTest = new CustomerData();
            systemUnderTest.AddCustomer(customer);
            var result = systemUnderTest.GetCustomerById(1);
            Assert.That(result.Name, Is.EqualTo("Abiodun Kazeem"));
        }



    }
}
