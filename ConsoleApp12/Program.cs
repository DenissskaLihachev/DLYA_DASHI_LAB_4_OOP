using My_Libs;

ListQueue li = new ListQueue();

//Console.Write("Введите имя: "); string name = Console.ReadLine();                             //вводим имя, фамилию и т.д.
//Console.Write("Введите фамилию: "); string secondname = Console.ReadLine();
//Console.Write("Введите пол: "); string gender = Console.ReadLine();
//Console.Write("Введите возраст: "); int age = Convert.ToInt32(Console.ReadLine());

//Person chel = new Person(name, secondname, gender, age);    //с параметрами                   //создаем объект класса с параметрами, которые мы написали
//li.add(chel);                                                                                 //с помощью метода добавляем этого чела в список
//Console.Clear();                                                                              //очистка консоли
//Console.WriteLine(li.get().ToString());                                                       //выводим этого челика



//Person chel2 = new Person();    //без параметров                                              //тут просто создается объект класса без параметров
//li.add(chel2);                                                                                //с помощью метода добавляем этого чела в список
//Console.Clear();                                                                              //очистка консоли
//Console.WriteLine(li.get().ToString());                                                       //выводим этого челика


li.add(new Person("Человеков", "Человек", "Мужчина", 18));      //просто заранее добавляем несколько челов в списко
li.add(new Person("Мужчинов", "Мужчин", "Мужчина", 19));
li.add(new Person("Женщинова", "ЕЖенщина", "Женщина", 13));
li.add(new Person("Мальчиков", "Мальчик", "Мужчина", 15));
li.add(new Person("фвфвфц", "фуцаацфа", "Мужчина", 25));

li.GetMassive();            //выводим их всех

Console.Read();