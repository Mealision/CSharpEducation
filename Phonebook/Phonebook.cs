using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Phonebook
{
    internal class Phonebook
    {
        private List<Abonent> abonents;

        private Phonebook()
        {
            abonents = new List<Abonent>();
            //LoadPhonebook();
        }

        public void AddAbonent(string phoneNumber, string name)
        {
            if (AbonentExists(phoneNumber))
            {
                Console.WriteLine("Абонент с таким номером уже существует.");
                return;
            }

            Abonent abonent = new Abonent
            {
                PhoneNumber = phoneNumber,
                Name = name
            };

            abonents.Add(abonent);
            SavePhonebook();
            Console.WriteLine("Абонент успешно добавлен.");
        }

        public void RemoveAbonent(string phoneNumber)
        {
            Abonent abonent = FindAbonentByPhoneNumber(phoneNumber);
            if (abonent != null)
            {
                abonents.Remove(abonent);
                SavePhonebook();
                Console.WriteLine("Абонент успешно удален.");
            }
            else
            {
                Console.WriteLine("Абонент с таким номером не найден.");
            }
        }

        public Abonent FindAbonentByPhoneNumber(string phoneNumber)
        {
            return abonents.Find(abonent => abonent.PhoneNumber == phoneNumber);
        }

        // Получение номера телефона по имени абонента
        public string FindPhoneNumberByName(string name)
        {
            Abonent abonent = abonents.Find(a => a.Name == name);
            return abonent != null ? abonent.PhoneNumber : null;
        }

        private bool AbonentExists(string phoneNumber)
        {
            return abonents.Exists(a => a.PhoneNumber == phoneNumber);
        }

        private void SavePhonebook()//Сделать самому
        {
            using (StreamWriter writer = new StreamWriter("phonebook.txt"))
            {
                foreach (Abonent abonent in abonents)
                {
                    writer.WriteLine($"{abonent.PhoneNumber},{abonent.Name}");
                }
            }
        }

        private void LoadPhonebook()
    {
        if (File.Exists("phonebook.txt"))
        {
            using (StreamReader reader = new StreamReader("phonebook.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        string phoneNumber = parts[0];
                        string name = parts[1];
                        Abonent abonent = new Abonent
                        {
                            PhoneNumber = phoneNumber,
                            Name = name
                        };
                        abonents.Add(abonent);
                    }
                }
            }
        }
    }
    }
}
