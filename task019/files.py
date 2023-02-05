
# Урок 24. Работа с файлами

file = open('file.txt', 'r', encoding='utf-8')

list_1 = list()
resultData = list()
for line in file.readlines():
    # print(line.split('\n')[0].split(';'))
    resultData.append(tuple(line.split('\n')[0].split(';')))

# print(file.read())

file.close()

print(resultData)

'''
a - режим добавления
w - режим на запись(перезаписывает файл)
r - режим считывания
'''
