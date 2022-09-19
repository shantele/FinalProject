# Итоговая проверочная работа

## Условие задачи: 
 **Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.** Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

 ## Примеры: 
*[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]*

*[“1234”, “1567”, “-2”, “computer science”] → [“-2”]*

*[“Russia”, “Denmark”, “Kazan”] → []*

## Алгоритм решения задачи:
* Объявить заранее заданный массив.
* Задать новый массив с размером равным первому массиву.
* Ввести переменную **shortSize** для обозначения размера нового массива, присвоив ей временно значение 0.
* Применить цикл **foreach** для того, чтобы обработать все элементы массива.
* Установить условие выбора элементов для нового массива (те элементы, длина которых не превышает трёх символов).
* Элементы, отвечающие условию, записать в новый массив, одновременно увеличивая переменную **shortSize** на единицу.
* Полученный новый массив вывести на печать.