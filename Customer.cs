using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Customer
    {
        private string _name;
        private string _phone;
        private string _cpf;
        private int _yearBirth;

        public Customer(string name, string phone, string cpf, int yearBirth)
        {
            _name = name;
            _phone = phone;
            if (Length cpf != 11)
            {
                throw new ArgumentException("O CPF têm apenas 11 digitos");
            };
            if (DateTime.Now.Year - yearBirth < 18)
            {
                throw new ArgumentException("O CPF têm apenas 11 digitos");
            };
        }

        public string Name 
        { 
            get => _name; 
            private set => _name = value; 
        }
        public string Phone 
        { 
            get => _phone; 
            set => _phone = value; 
        }
    }
}
