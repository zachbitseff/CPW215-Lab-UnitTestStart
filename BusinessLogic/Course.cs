using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {

        public byte NumberOfCredits
        {
            get
            { return NumberOfCredits; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("NumberOfCredits", "NumberOfCredits must be a non-negative value");
                }

                if (value > 30)
                {
                    throw new ArgumentException("NumberOfCredits", "NumberOfCredits cannot exceed 30");
                }

                NumberOfCredits = value;
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

            //Credits must be non-negative and no more than 30


            NumberOfCredits = numCredits;
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName
        {
            get
            { return InstructorName; }

            set
            {
                if (value.Equals(null))
                {
                    throw new ArgumentNullException("InstructorName", "InstructorName cannot be null");
                }

                InstructorName = value;
            }
        }


        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName
        {
            get
            { return CourseName; }

            set
            {
                if (value.Equals(null))
                {
                    throw new ArgumentNullException("CourseName", "CourseName cannot be null");
                }

                CourseName = value;
            }
        }




    }
}
