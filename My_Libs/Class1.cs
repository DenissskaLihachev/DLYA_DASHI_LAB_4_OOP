using System;
using System.Xml.Linq;

namespace My_Libs
{
    public class Person     // 1 класс
    {
        private string name { get; }    //имя
        private string secondName;      //фамилия
        private string gender;          //пол
        private int age;                //возраст

        public Person()     //конструктор, который вызывается по умолчанию при создании объекта класса
        {
            this.name = "Name";
            this.secondName = "Second Name";
            this.gender = "Gender";
            this.age = 0;
        }

        public Person(string name, string secondName, string gender, int age)   //конструктор с параметрами, который записывает в поля то, что ты напишешь при создании объекта класса
        {
            this.name = name;
            this.secondName = secondName;
            this.gender = gender;
            this.age = age;
        }

        public void print(Person data)      //метод, который тупо склеивает все поля (имя и т.д.) и выводит в консоль
        {
            Console.WriteLine("Имя: " + name + "\nФамилия: " + secondName + "\nПол: " + gender + "\nВозраст: " + age);
        }

        public override string ToString()   //тоже тупо склеивает, но не выводит а просто возвращает строку
        {
            return name + " " + secondName + " " + gender + " " + age;
        }
    }


    public class ListQueue  //2 класс
    {
        int count = 0; //счетчик, чтоб знать сколько челов
        internal class Element  //еще один класс, который реализует работу со списком
        {
            public Person data = null;  //поле, которое содержит данные по челу (имя, фамилия и т.д.)
            public Element next = null; //указатель на следующий элемент
        }

        private Element head = null;    //головка списка, т.е. первый элемент

        public void add(Person chel)    //метод добавления челов
        {
            Element e = new Element();
            e.data = chel;
            if (head == null)   //проверка есть ли первый эелемент
            {                   //если нету присваиваем туда переданные данные по челу
                head = e;
                count++;    //увеличиваем счетчик
            }
            else    //если же в головке кто-то есть, то ищем в while последний элемент в списке и пихаем туда данные чела
            {
                Element temp = new Element();
                temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = e;
                count++;    //увеличиваем счетчик
            }
        }

        public Person get() //метод, который выдергивает первого чела из списка (ну или лучше сказать первый элемент)
        {
            Element temp = new Element();
            temp = head;
            if (head != null)
            {
                head = head.next;
                return temp.data;
            }
            else
            {
                return null;
            }
        }

        public Person? GetIndex(int index)  //метод, с помощью которого по порядковому номеру (т.е. индексу) можно выдернуть чела (элемент) из списка
        {

            Element? cur = head;
            for (int i = 0; i < count; i++)
            {
                if (index == i)
                {
                    return cur?.data;
                }
                cur = cur?.next;
            }
            return null;
        }

        public void Set(Person? person, int index)  //метод, который ставит данные определенного чела, но определенное место (видишь там в парамтрах index, в индексе номер,
        {                                           //на то место по индексу он его поставит

            Element? cur = head;
            for (int i = 0; i < count; i++)
            {
                if (index == i)
                {
                    cur.data = person;
                    return;
                }
                cur = cur?.next;
            }
            return;
        }

        public void GetMassive()        //метод готорый выводит массивом весь список
        {
            Print();
            Console.WriteLine("\n\n");
            Sort();
            Print();
        }

        private void Sort()     //сортировка списка по фамилии, эта сортировка в задании была расписана как работает
        {
            int min = 0;
            int max = count - 1;
            int dir = min;
            do
            {
                for (int i = min; i <= max; i++)
                {
                    if (GetIndex(i)?.ToString()[0] > GetIndex(i + 1)?.ToString()[0])
                    {
                        Person? temp = GetIndex(i);
                        Set(GetIndex(i + 1), i);
                        Set(temp, i + 1);
                        dir = i + 1;
                    }
                }
                max = dir;
                for (int i = max; min <= i; i--)
                {
                    if (GetIndex(i)?.ToString()[0] < GetIndex(i - 1)?.ToString()[0])
                    {
                        Person? temp = GetIndex(i);
                        Set(GetIndex(i - 1), i);
                        Set(temp, i - 1);
                        dir = i - 1;
                    }
                }
                min = dir;
            } while (min != max);
        }

        private void Print()    //метод, который просто выводит чела
        {
            Element? cur = head;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(cur?.data?.ToString());
                cur = cur?.next;
            }
        }
    }
}