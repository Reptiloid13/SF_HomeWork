using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DeliveryHW_03
{
    public abstract class Person
    {
        public string FirstName;
        public string LastName;

        private string _email { get; set; }
        public string Email
        {
            get { return _email; }
            set
            {
                if (!value.Contains('@'))
                {
                    Console.WriteLine("Не верный формат");

                }
                else
                {
                    _email = value;
                }
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


        private Guid _id = Guid.NewGuid();
        public Guid id => _id;


        public Person(string firstName, string lastName, string email, string phoneNumber)
        {


            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;

        }

    }
}
