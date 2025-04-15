using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DeliveryHW_03
{
    public abstract class Person
    {
        public string FirstName;
        public required string LastName;
        public string FullName
        {
            get
            {
                return $"{FirstName},  {LastName}";
            }

        }


        public string _phoneNumber { get; set; }
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (!Regex.IsMatch(value, @"\+7[0-9]{10}"))
                {
                    throw new ArgumentException("Номер телефона должен начинаться с +7 и содержать 10 цифр");
                }
                _phoneNumber = value;
            }
        }

        public Address Address { get; set; }
        private Guid _id = Guid.NewGuid();
        public Guid id => _id;




    }

    public class Customer : Person
    {
        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                if (!value.Contains('@'))
                {
                    throw new ArgumentException("Не верный формат");
                }
                _email = value;
            }
        }
        public Address Address { get; set; }


    }

    public class Courier : Person
    {

    }

}
