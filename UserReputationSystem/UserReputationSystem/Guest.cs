﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UserReputationSystem
{
    class Guest : User
    {
        private DateTime dateOfBirth;
        private User user;
        private string temp;
        
        public Guest(string username, string password, string firstName, string lastName, DateTime dateOfBirth, int ratingsCount, double averageRating)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.ratingsCount = ratingsCount;
            this.averageRating = averageRating;
        }

        public Guest(User user, string temp)
        {
            this.user = user;
            this.temp = temp;
        }

        public Guest()
        {
        }

        #region GETTER's/SETTER's

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        #endregion

        public bool WriteGuestToFile(System.IO.StreamWriter file)
        {
            //write all admins back to the admin.txt to include any changes
            if (file.BaseStream != null)
            {
                string newGuest = "\r\n" + username + "," + password + "," + firstName + "," + lastName + "," + dateOfBirth.ToString("dd-MM-yyyy") + "," + ratingsCount + "," + averageRating;
                file.Write(newGuest);
                file.Close();
                return true;
            }
            else
            {
                return false;
            } 
        }

        public override string GetFullUserString()
        {
            string tempFirstName = this.firstName;
            string tempLastName = this.lastName;
            string tempDOB = this.dateOfBirth.ToString();

            string tempString = tempFirstName + "," + tempLastName + "," + tempDOB;
            return tempString;
        }
    }
}
