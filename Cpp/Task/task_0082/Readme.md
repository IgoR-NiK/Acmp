# Пересечение множеств
##### _(Время: 1 сек. Память: 16 Мб Сложность: 34%)_

Даны два неупорядоченных набора целых чисел (может быть, с повторениями). Выдать без повторений в порядке возрастания все те числа, которые встречаются в обоих наборах.

### Входные данные
В первой строке входного файла `INPUT.TXT` записано через пробел два целых числа `N` и `М` (`1 ≤ N`, `М ≤ 300 000`) — количество элементов первого и второго наборов, соответственно. В следующих строках записано сначала `N` чисел первого набора, а затем `M` чисел второго набора. Числа разделены пробелами или символами конца строки. Каждое из этих чисел попадает в промежуток от 0 до 10^5.

### Выходные данные
В выходной файл `OUTPUT.TXT` нужно записать в возрастающем порядке без повторений все числа, которые входят как в первый, так и во второй набор. Числа разделять одним пробелом. Если таких чисел нет, то выходной файл должен оставаться пустым.