using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class PersonModel
    {
        public string FirstName { private get; set; }
        public string LastName { get; private set; }

        private string _ssn;

        public string SSN
        {
            get 
            {
                string output;

                output = "***-**-" + _ssn.Substring(_ssn.Length - 4);

                _ssn = output;

                return _ssn; 
            }
            set { _ssn = value; }
        }

        public PersonModel(string lastName)
        {
            LastName = lastName;
        }

        public PersonModel()
        {

        }

        private string _fullname;

        public string FullName
        {
            get
            {
                _fullname = FirstName + " " + LastName;
                return _fullname; 
            }
            
        }

    }
}
