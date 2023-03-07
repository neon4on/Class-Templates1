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
                Console.WriteLine("3 - Вывод заявок по номер заявки рейса \n");
                Console.WriteLine("4 - Удаление заявок по номеру рейса \n");
                Console.WriteLine("5 - Выход из программы \n");
                Console.WriteLine("ВЫБОР: ");
                select = Convert.ToInt32(Console.ReadLine());
            } while ((select < 1) || (select > 5));

            return select;
        }

        public class Avia : IEquatable<Avia>
        {
            public string target { get; set; } //Пункт назначения
            public string fio { get; set; } //ФИО:
            public string uwant { get; set; } //Желаемая дата вылета

            public int PartId { get; set; } //Номер рейса

            public override string ToString()
            {
                return "Пункт назначения: " + target + ";  Номер рейса: " + PartId + ";  ФИО: " + fio + ";  Желаемая дата вылета: " + uwant;
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
                parts.Add(new Avia() { target = "Ульяновск", PartId = 5 , fio = "Каменских", uwant = "Казань" });
                string a, c, d;
                int b;

                

                //------------------------------------------------------------

                Console.ForegroundColor = ConsoleColor.Green;

                int select;
                do
                {
                    // вызываем главное меню и выполняем выбор пользователя
                    select = Menu();
                    switch (select)
                    {
                        case 1:
                            {
                                Console.Write("Пункт назначения: ");
                                a = Console.ReadLine();
                                Console.Write("Номер рейса: ");
                                b = Convert.ToInt32(Console.ReadLine());
                                Console.Write("ФИО: ");
                                c = Console.ReadLine();
                                Console.Write("Желаемая дата вылета: ");
                                d = Console.ReadLine();
                                parts.Add(new Avia() { target = a, PartId = b, fio = c, uwant = d });
                                Console.ReadLine();
                                break;
                            }
                        case 2:
                            {
                                int i = 1;
                                Console.WriteLine("\n");
                                foreach (Avia aPart in parts)
                                {
                                    Console.Write($"{i}" + "\t");
                                    Console.WriteLine(aPart);
                                    i++;
                                }
                                Console.ReadLine();
                                break;
                            }
                        case 3:
                            {
                                //Вывод заявок по номеру рейса
                                Console.WriteLine("Введите номер заявки, который необходимо вывести: ");
                                b = Convert.ToInt32(Console.ReadLine()) - 1;
                                var firstElement = parts[b];
                                Console.WriteLine(firstElement);
                                Console.ReadLine();
                                break;
                            }
                        case 4:
                            {
                                //Удаление заявок по номеру рейса
                                Console.WriteLine("Введите номер рейса, который необходимо удалить: ");
                                b = Convert.ToInt32(Console.ReadLine());
                                parts.Remove(new Avia() { PartId = b});
                                Console.WriteLine("\n");
                                Console.ReadLine();
                                break;
                            }
                    }
                } while (select != 5);
            }
        }
    }
}
