using System;


namespace StkManagmentSystem
{
    class patients
    {
        public string firstname;
        public string middlename;
        public string lastname;
        public string gender;
        public string dob;
        public string address;
        public string phonenr;
        public string nok;
        public string idnr;


        public string Firstname
        {
             get { return firstname; }
             set {firstname = value; }
        }

        public string Middlename
        {
            get { return middlename; }
            set { middlename = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Phonenr
        {
            get { return phonenr; }
            set { phonenr = value; }
        }

        public string Nok
        {
            get { return nok; }
            set { nok = value; }
        }

        public string Idnr
        {
            get { return idnr; }
            set { idnr = value; }
        }
    }

    
}
