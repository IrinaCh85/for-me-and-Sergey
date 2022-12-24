# Last-project
## Задача : 

### Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Описание алгоритма решения:

## Во-первых, объявляется массивы: первоначальный и следующий такой же длины. 

## Во-вторых, используется метод, в котором цикл такого же размера как и длина массива.

## Далее, внутри цикла идет проверка условия (<=3), если верно, то элемент первого массива заносится в count элемент второго массива. 

## Введенная переменная count нужна, чтобы поочередно вносить из первого массива во второй и чтобы потом не было пробелов. 

## В конце присваивается увеличенная переменная count на 1 и возвращается к циклу for в котором i увеличивается на единицу. И так проверяется до конца.