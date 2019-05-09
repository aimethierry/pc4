﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1___Linked_List_of_Persons
{
    class Linked_List
    {
        public Person firstPerson;
        public int count = 0;

        //Constructors
        public Linked_List()
        {
            firstPerson = new Person("Mohammad Reza");
            count++;
        }

        ///Methods
        
        //Finding Methods
        public Person FindPersonBefore(Person current)
        {
            Person temp = firstPerson;

            while (temp.Next != current)
            {
                temp = temp.Next;
            }

            return temp;
        }
        public Person FindPerson(string name)
        {
            Person temp = firstPerson;
            while (temp.Name != name && temp.Next!=null)
            {
                temp = temp.Next;
            }

            if (temp.Name == name)
            {
                return temp;
            }
            else
            {
                return null;
            }

        }
        public Person FindLastPerson()
    {
        Person temp = firstPerson;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }

        return temp;
    }
        public Person FindPersonAt(int i)
        {
            int counter = 1;
            if (i == 1)
            {
                return firstPerson;
            }
            else
            {
                var temp = firstPerson;
                do
                {
                    temp = temp.Next;
                    counter++;
                } while (counter != i);

                return temp;
            }
        }

        //Deletion Methods
        public void DeletePerson(Person temp)
        {
            Person first = firstPerson;
            Person last = FindLastPerson();
            if (first == last && first.Name == temp.Name)
            {
                firstPerson = null;
                count--;
            }
            else if (first.Name == temp.Name)
            {
                DeleteAPersonFromFront();
            }
            else if (last.Name == temp.Name)
            {
                DeleteAPersonFromEnd();
            }
            else
            {
                DeletePersonInBetween(temp);
            }
            
        }
        public void DeletePersonInBetween(Person p)
        {
            p.Next.Previous = p.Previous;
            p.Previous.Next = p.Next;
            p = null;
            count--;
        }
        public void DeleteAPersonFromFront()
        {
            Person temp = firstPerson.Next;
            if (temp != null)
            {
                firstPerson.Next.Previous = null;
                firstPerson.Next = null;
                firstPerson = temp;
            }
            else
            {
                firstPerson = null;
            }

            count--;


        }
        public void DeleteAPersonFromEnd()
        {
            Person last = FindLastPerson();
            if (last != null)
            {
                
                if (last.Previous != null)
                {
                    last.Previous.Next = null;
                }
                else
                {
                    firstPerson = null;

                }

                count--;
            }
            
            
            
        }

        //Insertion Methods
        public void AddNewPerson(string name)
        {
            if (firstPerson == null)
            {
                firstPerson = new Person(name);
                
            }
            else
            {
                Person newPerson = new Person(name);
                var current = firstPerson;
                while (current != null)
                {
                    if ((newPerson.Name.CompareTo(current.Name) <= 0) && current == firstPerson)
                    {
                        AddPersonInFront(newPerson);
                        break;
                    }
                    else if (newPerson.Name.CompareTo(current.Name) <= 0)
                    {
                        AddPersonBeforePerson(current, newPerson);
                        break;
                    }

                    current = current.Next;
                    if (current == null)
                    {
                        AddPersonAtTheEnd(newPerson);
                    }
                }
            }

            
        }
        public void AddPersonInFront(Person p)
        {
            if (firstPerson != null)
            {
                p.Next = firstPerson;
                firstPerson.Previous = p;
                firstPerson = p;
            }
            else
            {
                firstPerson = p;
            }

            count++;
        }
        public void AddPersonAtTheEnd(Person p)
        {
            Person temp = FindLastPerson();
            temp.Next = p;
            p.Previous = temp;
            count++;
        }
        public void AddPersonBeforePerson(Person current, Person New)
        {
            New.Previous = current.Previous;
            New.Next = current;
            current.Previous = New;
            New.Previous.Next = New;
            count++;
        }

    }
}
