from random import randint

min = 0
max = 100000

x = randint(min, max)

count_enum = 0
# Метод последовательного перебора
for i in range(min, max):
    count_enum += 1
    if i == x:
        # print("Число найдено!")
        break
print("Метод перебора занял",
      count_enum, "итераций")

count_rnd = 1
# Метод случайного отгадывания
y = randint(min, max)
while x != y:
    y = randint(min, max)
    count_rnd += 1
# print("Число найдено!")
print("Метод отгадывания занял",
      count_rnd, "итераций")

# Бинарный поиск
count_bin = 1
y = (max + min) // 2
while x != y:
    if x < y:
        # print("искомое число меньше")
        max = y - 1
    else:
        # print("искомое число больше")
        min = y + 1
    y = (max + min) // 2
    count_bin += 1
    # print(min,y,max)

print("Бинарный поиск занял",
      count_bin, "итераций")
print("Загаданное число было -", x)
