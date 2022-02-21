using System;

namespace _9._6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число : ");

            string result = Console.ReadLine();

            int number = 0;

            try
            {
                number = int.Parse(result);
            }
            catch(ApplicationException ex)
            {

            }
            catch(ArgumentNullException ex)
            {

            }
            catch (OverflowException ex)
            {

            }
            catch (FormatException ex)
            {
                Console.WriteLine("A format exception has occured");
                Console.WriteLine("Information is below: ");
                Console.WriteLine(ex.ToString());
            }

            catch(Exception ex)
            {

            }
            Console.WriteLine(number);
            //Обработка персонального исключения
            try
            {
                Person p = new Person { Name = "Mikayo", Age = 13 };

            }

            catch(PersonException ex) 
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.Read();
        }
        
    }

    //Обработка персонального исключения
    class Person
    {
        private int age;
        public string Name { get; set; }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18)
                {
                    throw new Exception("Лицам до 18 регистрация запрещена");
                    

                }
                else
                {
                    age = value;
                }
            }
        }
    }
    //Обработка персонального исключения
    class PersonException : Exception
    {
        public PersonException(string message)
            : base(message)
        { }
    }


}
