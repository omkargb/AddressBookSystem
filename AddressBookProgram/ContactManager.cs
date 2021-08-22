using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProgram
{
    class ContactManager
    {
        //options to select operation
        public static void Operations()
        {
            Console.WriteLine("\n Available options :\n 1.Add_contact \t 2.Edit_contact \t 3.Delete_Contact \t 4.View_contacts \n 5.New_address_book \t\t 6.Search_person_by_cityOrState \n 7.ViewPerson_ByCityOrState \t 7.GetCount_Ofperson_byCityOrState \t 8.Sort_addressBook_contacts \n 0.Exit \n");

            Console.Write(" Provide option :  ");
            int userAction = int.Parse(Console.ReadLine());
            string findName, searchAdrBookName;
            switch (userAction)
            {
                case 1:
                    Console.Write("\n Enter addressbook name to select and add contact : ");
                    searchAdrBookName = Console.ReadLine();
                    CheckAddresssBook(searchAdrBookName);
                    AddressBookMain.AddPersonInfo(searchAdrBookName);
                    Operations();
                    break;

                case 2:
                    DisplayABList();
                    Console.Write("\n  Enter addressbook name to find and edit contact : ");
                    searchAdrBookName = Console.ReadLine();
                    Console.Write("\n  Enter Firstname to find and edit contact : ");
                    findName = Console.ReadLine();
                    CheckAddresssBook(searchAdrBookName);

                    AddressBookMain.ModifyPersonInfo(searchAdrBookName, findName);
                    AddressBookMain.DisplayContacts(searchAdrBookName);
                    Operations();
                    break;

                case 3:
                    DisplayABList();
                    Console.Write("\n  Enter addressbook name to find and delete contact : ");
                    searchAdrBookName = Console.ReadLine();
                    Console.Write("\n  Enter Firstname to find and delete contact : ");
                    findName = Console.ReadLine();
                    CheckAddresssBook(searchAdrBookName);

                    AddressBookMain.DeletePersonInfo(searchAdrBookName, findName);
                    AddressBookMain.DisplayContacts(searchAdrBookName);
                    Operations();
                    break;

                case 4:
                    DisplayABList();
                    Console.Write("\n\n Enter address book name : ");
                    searchAdrBookName = Console.ReadLine();
                    AddressBookMain.DisplayContacts(searchAdrBookName);
                    Operations();
                    break;

                case 5:

                    AddressBookMain.NewAdrBook();
                    Operations();
                    break;

                case 6:
                    AddressBookMain.SearchPerson();
                    Operations();
                    break;

                case 7:
                    AddressBookMain.DisplayByCityState();
                    Operations();
                    break;

                case 8:
                    AddressBookMain.SortAddressBook();
                    Operations();
                    break;

                case 0: break;
                
                default:
                    Console.WriteLine(" Invalid option.");
                    break;
            }

             void CheckAddresssBook(string searchAdrBookName)
            {
                int bookFound = 1;
                foreach (var ab in AddressBookMain.contactsDictionary)
                {
                    if ((ab.Key).ToUpper().Equals(searchAdrBookName.ToUpper()))
                    {   
                        continue;   
                    }
                    else
                    {
                        bookFound = 0;
                    }
                }
                if(bookFound == 0)
                {
                    Console.WriteLine(" --> Address book not found.");
                    Operations();
                }
            }

            void DisplayABList()
            {
                Console.Write("\n Here are available address books : ");
                foreach (var ab in AddressBookMain.contactsDictionary)
                {
                    Console.Write("\t" + ab.Key);
                }
            }
        }

    }
}
