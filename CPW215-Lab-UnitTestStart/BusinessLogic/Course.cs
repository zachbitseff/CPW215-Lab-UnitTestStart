using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {

        private byte _numberOfCredits;

        public byte NumberOfCredits
        {
            get
            { return _numberOfCredits; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("NumberOfCredits", "NumberOfCredits must be a non-negative value");
                }
                else if (value > 29)
                {
                    throw new ArgumentException("NumberOfCredits", "NumberOfCredits must be less than 30");
                }

                _numberOfCredits = value;
            }
        }



        public Course(string courseName)
        {

            CourseName = courseName;

            // default InstructorName
            InstructorName = "STAFF";

            // default numCredits
            NumberOfCredits = 5;
        }



        public Course(string courseName, string instructorName, byte numCredits)
        {

            CourseName = courseName;

            InstructorName = instructorName;

            NumberOfCredits = numCredits;
        }


        private string _instructorName;
        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName 
       {
            get
            { return _instructorName; }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("InstructorName", "InstructorName cannot be null");
                }

                _instructorName = value;
            }
        }

        private string _courseName;
        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName
        {
            get
            { return _courseName; }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("CourseName", "CourseName cannot be null");
                }

                _courseName = value;
            }
        }




    }
}
