# NET.W.2016.01.Voronko.03

Для тех, кто не сделал для Day 1 - Создание многофайловой сборки на примере пары-тройки классов на свой выбор (по аналогии с примером из файла Assemblies.pptx, Assembly example.zip), назначение сборке строго имени, помещение сборки в GAC (по аналогии с примером из файла Assemblies.pptx, Assembly example.zip).
Джеффри Рихтер. CLR via C#. Часть I. Основы CLR.
Joseph Albahari (Джозеф Албахари), Ben Albahari (Бен Албахари) C# 5.0 in a Nutshell. Chapter 2. C# Language Basics, Chapter 6, Chapter 7. (The Array Class) 
Jeffrey Richter (Джеффри Рихтер) CLR via C#. Chapter 14, Chapter 16.


Дан массив целых чисел. Найти в массиве и вернуть такой индекс n, для которого сумма элементов слева от него равно сумме элементов справа. Если такого индекса нет вернуть null (-1).
Например.
•	Для массива {1,2,3,4,3,2,1} функция вернет индекс 3, поскольку на 3-й
 позиции массива, суммы слева от индекса ({1,2,3}) и справа от индекса ({3,2, 1})
  равны 6.
•	Для массива {1,100,50, -51,1,1} функция вернет индекс 1, поскольку на 1-й 
позиции массива, суммы слева от индекса ({1}) и справа от индекса ({50, -51,1,1 }) 
равны 1.
Входные данные: Целочисленный массив длины 0 <length <1000. Числа в массиве могут быть любым целыми положительными или отрицательными.
Выходные данные: Наименьший индекс, для которого сторона слева равна стороне справа. Если такого индекса не существует вернуть -1(null).

Для двух строк, включающих только символы от 'a'  до  'z', вернуть конкатенированную отсортированную по алфавиту строку, исключая повторяющиеся символы.
Например.
a = "xyaabbbccccdefww"
b = "xxxxyyyyabklmopq"
Longest(a, b) -> "abcdefklmopqwxy"

a = "abcdefghijklmnopqrstuvwxyz"
Longest(a, a) -> "abcdefghijklmnopqrstuvwxyz

Даны два целых знаковых четырехбайтовых числа и две позиции битов i и j (i<j). Реализовать алгоритм вставки одного числа в другое так, чтобы второе число занимало позицию с бита j по бит i (биты нумеруются справа налево).
Например.
Insertion(8,15,0,0) ->9
Insertion(0, 15, 30, 30) ->1073741824
Insertion(0, 15, 0, 30) -> 15
Insertion(15, -15, 0, 4) -> 31
Insertion(15, int.MaxValue, 3, 5)->63
______________________________________________________________________________
27.10.2016 ( deadline - 18.00)
Разработать unit-тесты с использованием как NUnit Framework, так и MS Unit Test Framework (здесь желательно попробовать подход  Data Driven Testing, пример в архиве UnitTesting.zip, проекты DDT.Demo и DDT.Demo.Tests) для тестирования метода из задачи 5. 
Разработать unit-тесты для тестирования методов задач 6, 7. 
Разработать метод, позволяющий вычислять корень n-ой степени из числа методом Ньютона с заданной точностью. Разработать unit-тесты для тестирования полученного метода.
Реализовать метод расширения для получения двоичного представления вещественного числа двойной точности в формате IEEE 754. Разработать модульные тесты.
