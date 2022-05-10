# ControlWorkFirstQuart
# Контрольная работа по итогу прохождения первого блока обучения на программе "Разработчик"

*Само задание можно посмотреть в файле [README123](README123.md)

---
---

## 1. Создание репозитория

В существующем аккаунте [GitHub.com](https://github.com/FA-lex) создаю репозиторий [ControlWorkFirstQuart](https://github.com/FA-lex/ControlWorkFirstQuart), в этом репозитории и будет выложена данная итоговая работа.


## 2. Создание блок-схемы будущей программы 

Как всякая блок-схема, и моя не исключение, имеет начало: 

![start](Image/start.png)

По условию задания " `Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма` ", поэтому у пользователя спрашиваем какой будет вариант. Предварительно указав что вариант нулевой (отсутствующий) и пока пользователь не выберет один из предложенных вариантов будем запрашивать снова: 

![выбор варианта массива](Image/select_input.png)

Когда пользователь сделает выбор из предложенного, то далее либо запрашиваем массив, либо подсовываем алгоритму заранее подготовленный (взависимости от выбора пользователя).
Если пользователь решил вводить массив вручную - просим вводить элементы через запятую, и затем разделяем введеную строку на элементы и записываем в массив.

![запрос массива](Image/request_massiv.png)

Выбор сделан, массив есть, теперь передаем этот массив в функцию поиска элементов массива с длиной менее или равно 3-м символам.

![комментарий к области выделения функции](Image/function.png)

Здесь функцию не выделяю в отдельную блок-схему, т.к. это и есть суть задания, но выделяю ее областью комментария (в программе будет сделано методом).

Алгоритм функции - такой: циклом просматриваем массив и считаем сколько подходящих элементов в массиве, инициализируем пустой массив необходимого размера в который будем записывать нужные элементы. С помощью цикла `for` просматриваем длину каждого элемента массива и подходящие по параметрам записываем в массив через разделитель. Полученный массив возвращаем из функции.

![функция выборки элементов менее трех символов](Image/function_select_elements.png)

Далее результат выводим пользователю с помощью функции вывода в консоль.

![вывод результата](Image/print_rezult.png)

Функция вывода в консоль принимает в себя массив и выводит в консоль  поэлементно с помощью цикла.

![функция вывода массива в консоль](Image/function_print_array.png)

В итоге вся блок-схема выглядит так:

![итоговая блок-схема](Image/flow_chart.png)

## 3. Написание программы

