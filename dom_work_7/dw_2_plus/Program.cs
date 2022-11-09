//Реализовать односвязанный список на c#. Сделать функцию, которая будет его разворачивать.
using System;
using System.Collections.Generic;

LinkedList<string> linkedList = new LinkedList<string>();
// добавление элементов
linkedList.AddFirst("Tom");
linkedList.AddFirst("Alice");
linkedList.AddFirst("Bob");
linkedList.AddFirst("Sam");
 
// выводим элементы
foreach(var item in linkedList)
{
    Console.WriteLine(item);
}
// удаляем элемент
linkedList.Remove("Alice");
foreach (var item in linkedList)
{
    Console.WriteLine(item);
}
// проверяем наличие элемента
bool isPresent = linkedList.Contains("Sum");
Console.WriteLine(isPresent == true ? "Sam присутствует" : "Sam отсутствует");
 
// добавляем элемент в начало            
linkedList.AddFirst("Bill");
foreach (var item in linkedList)
{
    Console.WriteLine(item);
}