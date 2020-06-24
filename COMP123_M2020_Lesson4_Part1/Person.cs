﻿using System;
using System.Collections.Generic;
using System.Text;

namespace COMP123_M2020_Lesson4_Part1
{
    class Person
    {

        // PRIVATE INSTANCE VARIABLES

        private string m_name;
        private int m_age;


        // PUBLIC PROPERTIES
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        public int Age
        {
            get
            {
                return m_age;
            }
            set
            {
                m_age = value;
            }
        }
        // CONSTRUCTOR
        public Person(string name, int age)
        {
            m_name = name;
            m_age = age;
        }

            // PRIVATE METHODS

            // PUBLIC METHODS

            public void saysHello()
            {
                Console.WriteLine($"{Name} says Hello");
            }

            /// <summary>
            ///
            /// This method overrides the ToString method of parent class
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                string outputString = "";

                outputString += $"Name : {Name}  \n";
                outputString += $"Age  : {Age}     ";

                return outputString;

            }
    }
    }

