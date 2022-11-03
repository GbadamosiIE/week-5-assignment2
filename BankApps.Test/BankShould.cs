using BankApp.Data;
using BankApp.Implementations;
using BankApp.Interfaces;
using BankApp.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApps.Test
{

    public class BankShould
    {
        private readonly Bank systemUnderTest;
        private readonly Mock<ICustomerData> _customerDataMock = new Mock<ICustomerData>();
        private readonly Mock<ICustomer> _customerMock = new Mock<ICustomer>();

        public BankShould()
        {
            systemUnderTest = new Bank(_customerDataMock.Object, _customerMock.Object);
        }
        
        



    }
}

