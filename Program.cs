using System;

namespace Lab_1_1
{
    class Student
    {
        private string name;
        private int age;
        private int course;
        private double rating;
        private string role;

        public Student(string name, int age, int course, double rating )
        {
            //конструктор з параметрами - ініціалізує об'єкт
            this.name = name;
            this.age = age;
            this.course = course;
            this.rating = rating;
        }

        public void EditStudent(string name, int age, double rating)
        {
            //метод редагування даних про студента
            this.name = name;
            this.age = age;
            this.rating = rating;
        }

        public void StudentRating()
        {
            //метод виведення повідомлення залежно від рейтингу
            if (rating >= 82)
                Console.WriteLine("Привіт відмінникам");
            else
            if (rating <= 60)
                Console.WriteLine("Перездача! Треба краще вчитися!");
            else
                Console.WriteLine("Можна вчитися ще краще!");
        }
        
        public string GetRole(int course)
        {
            //визначення ролі залежно від курсу
            if (course <= 4)
                role = "бакалавр";
            else
                role = "магістр";
            return role;
        }
        
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            } 
        }
        public int Course
        {
            get
            {
                return course;
            }
            set
            {
                course = value;
            } 
        }
        public double Rating
        { 
            get
            {
                return rating;
            }
            set
            {
                rating = value;
            } 
        }
    }
}

namespace Lab_1_2
{
    class PrintedEdition
    {
        // Поля класу
        private string name;
        private string type; // газета або журнал
        private decimal price;
        private int pages_num;

        // Конструктор без параметрів
        public PrintedEdition() {}
        
        // Властивості для доступу до полів
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public int PagesNum
        {
            get { return pages_num; }
            set { pages_num = value; }
        }
        
        // Перший метод: виводить назву і тип видання
        public void GetNameAndType()
        {
            Console.WriteLine($"Назва: {name}, Тип: {type}");
        }
        // Другий метод: аналізує ціну і тип
        public void AnalyzePriceAndType()
        {
            if (price > 10 && type.ToLower() == "газета")
            {
                Console.WriteLine($"Це занадто дорога газета: {price} грн");
            }
            else if (price < 10 && type.ToLower() == "журнал")
            {
                Console.WriteLine($"Це дешевий журнал: {price} грн");
            }
            else
            {
                Console.WriteLine($"Це видання: {type}, Його ціна: {price} грн");
            }
        }
    }
}


    
class Program
{
    static void Main(string[] args)
    {
        // програма, яка працює з класом Student
        Lab_1_1.Student stud = new Lab_1_1.Student("Вася", 19, 2, 60);
        string stRole = stud.GetRole(2);
        Console.WriteLine("Цей студент  " + stRole);
        stud.EditStudent("Петро", 20, 90);
        string studentName = stud.Name;
        Console.WriteLine("Оновлені дані про студента");
        Console.WriteLine("Ім’я " + stud.Name);
        Console.WriteLine("Вік " + stud.Age);
        Console.WriteLine("Курс " + stud.Course);
        Console.WriteLine("Рейтинг " + stud.Rating);
        
        // програма, яка працює з класом PrintedEdition
        Lab_1_2.PrintedEdition edition = new Lab_1_2.PrintedEdition()
        {
            Name = "Новини України",
            Type = "газета",
            Price = 15.5m,
            PagesNum = 32
        };

        edition.GetNameAndType();
        edition.AnalyzePriceAndType();
    }
}
