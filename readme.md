# Блок-схема алгоритма решения задачи
[Блок-схема алгоритма решения задачи](https://disk.yandex.ru/d/Cw5WzAs4wkTi4AБлок-схема.png)


# Описание алгоритма решения задачи

1. Пользователь указывает количество элементов (N), которое он хочет ввести в массив.

2. Объявляется первоначальный массив.

3. Пользователь вводит элементы массива с клавиатуры, после ввода каждого элемента нажимает Enter.

4. Массив заполняется элементами в цикле N раз.

5. Объявляется новый массив.

6. Вводится счетчик элементов нового массива.

7. Далее проходим по первоначальному массиву в новом цикле и проверяем выполнение условия: длина строки должна быть меньше, либо равна 3 символам.

8. Если элемент подходит под данное условие, то он добавляется в новый массив, а счетчик элементов нового массива увеличивается на 1.

9. Далее возвращаемся к началу цикла и проверяем поочередно все элементы. 

10. Выводим на печать первоначальный и новый массивы.


# Решение задачи на С#

Решение задачи на С# находится на FinalWork/Program.cs