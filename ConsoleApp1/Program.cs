using System;
using System.Collections;
using System.Collections.Generic;
namespace ConsoleApp1
{


    internal class Program
    {
        /// <summary>
        /// Главное меню
        /// </summary>
        /// <returns></returns>
        static int Menu()
        {
            int select;

            do
            {
                Console.Clear();
                Console.WriteLine("Заявки на авиабилеты: \n\n");
                Console.WriteLine("1 - Добавление новой заявки \n");
                Console.WriteLine("2 - Вывод всех заявок на экран \n");
                Console.WriteLine("5 - Выход из программы \n");
                Console.WriteLine("ВЫБОР: ");
                select = Convert.ToInt32(Console.ReadLine());
            } while ((select < 1) || (select > 5));

            return select;
        }

        public class Avia : IEquatable<Avia>
        {
            public string target { get; set; } //Пункт назначения
            public string number { get; set; }//Номер рейса
            public string fio { get; set; } //ФИО:
            public string uwant { get; set; } //Желаемая дата вылета
            public string PartName { get; set; }

            public int PartId { get; set; }

            public override string ToString()
            {
                return "ID: " + target + "   Name: " + number + "ID: " + target + "   Name: " + number;
            }
            public override bool Equals(object obj)
            {
                if (obj == null) return false;
                Avia objAsPart = obj as Avia;
                if (objAsPart == null) return false;
                else return Equals(objAsPart);
            }
            public override int GetHashCode()
            {
                return PartId;
            }
            public bool Equals(Avia other)
            {
                if (other == null) return false;
                return (this.PartId.Equals(other.PartId));
            }


            static void Main(string[] args)
            {
                // В односвязанный список необходимо объект в котором будет несколько полей
                List<Avia> parts = new List<Avia>();
                parts.Add(new Avia() { PartName = "crank arm", PartId = 1234 });
                parts.Add(new Avia() { PartName = "chain ring", PartId = 1334 });
                parts.Add(new Avia() { PartName = "regular seat", PartId = 1434 });
                parts.Add(new Avia() { PartName = "banana seat", PartId = 1444 });
                parts.Add(new Avia() { PartName = "cassette", PartId = 1534 });
                parts.Add(new Avia() { PartName = "shift lever", PartId = 1634 });
                parts.Add(new Avia() { target = "shift lever", number = "55", fio = "1634", uwant = "4829" });
                
                Console.WriteLine();
                foreach (Avia aPart in parts)
                {
                    Console.WriteLine(aPart);
                }
                Console.ReadLine();

                //------------------------------------------------------------

                Console.ForegroundColor = ConsoleColor.DarkGreen;

                //int select;
                //do
                //{
                //    // вызываем главное меню и выполняем выбор пользователя
                //    select = Menu();
                //    switch (select)
                //    {
                //        case 1:
                //            {
                //                Console.Write("Пункт назначения: ");
                //                person1.target = Console.ReadLine();
                //                Console.Write("Номер рейса: ");
                //                person1.number = Console.ReadLine();
                //                Console.Write("ФИО: ");
                //                person1.fio = Console.ReadLine();
                //                Console.Write("Желаемая дата вылета: ");
                //                person1.uwant = Console.ReadLine();
                //                List1.Add(person1);
                //                Console.ReadLine();
                //                break;
                //            }
                //        case 2:
                //            {
                //                int i = 1;
                //                Console.WriteLine("\n");
                //                foreach (var item in List1)
                //                {
                //                    Console.Write($"{i}" + "\t");
                //                    Console.Write(person1.target + " ");
                //                    Console.Write(person1.fio + " ");
                //                    Console.Write(person1.number + " ");
                //                    Console.Write(person1.uwant + " ");
                //                    Console.WriteLine("\n");
                //                    i++;
                //                }
                //                Console.ReadLine();
                //                break;
                //            }
                //        case 3:
                //            {
                //                //Вывод заявок по номеру рейса
                //                Console.WriteLine("\n");
                //                Console.ReadLine();
                //                break;
                //            }
                //        case 4:
                //            {
                //                //Удаление заявок по номеру рейса
                //                Console.WriteLine("\n");
                //                Console.ReadLine();
                //                break;
                //            }
                //    }
                //} while (select != 5);
            }
        }
    }
}
