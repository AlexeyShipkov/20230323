/* 
Задача: 
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

/*
Формируем стартовый массив двумя методами (создание строки и создание массива из строк)
Будет состоять из случайного (от 5 до 10) количества элементов-строк, 
каждая строка состоит из случайного набора символов, длина выбирается случайно, до 7 символов в строке
*/

        string RandomString()  //метод создания случайной строки
        {
            Random myRand = new Random();
            string returnedStr = "";
            for (int i = 0; i < new Random().Next(1, 7); i++)  // длина набора от 1 до 7 символов, длина выбирается случайно
            {
                char myChar = (char)myRand.Next(33, 126); // берем по ASCII таблице кодировки символов буквы и знаки от ! до }
                returnedStr += myChar;
            }
            return returnedStr;
        }

        string[] RandomString2()  // метод создания массива случайных строк, количество элементов массива от 5 до 10, выбирается случайно 
        {
            int len = new Random().Next(5, 10);
            string[] returnedArray = new string[len];
            for (int i = 0; i < len; i++)
            {
                returnedArray[i] = RandomString();  // записываем в массив случайную строку
            }
            return returnedArray;
        }



        void ShowArray(string[] array)   //  метод вывода массива 
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
        }


        string[] newArray = RandomString2(); // создание начального массива
        ShowArray(newArray);  //вывод начального массива

        int lenStr = newArray.Length;
        int resLen = 0;
        for (int i = 0; i < lenStr; i++)  // определяем количество элементов с длиной не более 3
        {
            if (newArray[i].Length <= 3) resLen++;
        }

        string[] resultArray = new string[resLen]; // определение результирующего массива
        int k = 0;
        for (int i = 0; i < lenStr; i++)  // записываем в результирующий массив элементы начального массива с длиной не более 3 символов
        {
            if (newArray[i].Length <= 3)
            {
                resultArray[k] = newArray[i];
                k++;
            }
        }
        ShowArray(resultArray);   // вывод результирующего массива
