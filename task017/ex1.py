# Задача - есть список определённой длины, состоящий из 0 и 1.
# Цель - найти решение максимальной суммы цифр списка.
# Для этого будет использоватьяс генетический алгоритм

import random
import matplotlib.pyplot as plt

# константы задачи
ONE_MAX_LENGTH = 100  # длина подлежащей оптимизации битовой строки

# константы генетического алгоритма
POPULATION_SIZE = 200  # количество индивидуумов в популяции
P_CROSSOVER = 0.9  # вероятность скрещивания
P_MUTATION = 0.1  # вероятность мутации индивидуума
MAX_GENERATIONS = 50  # максимальное количество поколений

RANDOM_SEED = 42
random.seed(RANDOM_SEED)


class FitnessMax():
    def __init__(self):
        self.values = [0]


class Individual(list):
    def __init__(self, *args):
        super().__init__(*args)
        self.fitness = FitnessMax()


def oneMaxFitness(individual):
    return sum(individual),  # кортеж


def individualCreator():
    return Individual([random.randint(0, 1) for i in range(ONE_MAX_LENGTH)])


def populationCreator(n=0):
    return list([individualCreator() for i in range(n)])


population = populationCreator(n=POPULATION_SIZE)  # создание популяции
generationCounter = 0  # счётчик числа поколений

# список приспособленностей особи
fitnessValues = list(map(oneMaxFitness, population))

for individual, fitnessValue in zip(population, fitnessValues):
    individual.fitness.values = fitnessValue

maxFitnessValues = []  # максимальная приспособленность особи в текущей популяции
meanFitnessValues = []  # средняя приспособленность всех особей в текущей популяции

# клонирование индивидуумов, чтобы не было повторений одних и тех же ссылок


def clone(value):
    ind = Individual(value[:])
    ind.fitness.values[0] = value.fitness.values[0]
    return ind

# функция турнирного отбора


def selTournametnt(population, p_len):
    offspring = []
    for n in range(p_len):
        i1 = i2 = i3 = 0
        while i1 == i2 or i1 == i3 or i2 == i3:
            i1, i2, i3 = random.randint(
                0, p_len-1), random.randint(0, p_len-1), random.randint(0, p_len-1)

        offspring.append(max([population[i1], population[i2],
                         population[i3]], key=lambda ind: ind.fitness.values[0]))
    return offspring

# одноточечный кроссинговер


def cxOnePoint(child1, child2):
    s = random.randint(2, len(child1)-3)  # точка разреза кромосомы
    child1[s:], child2[s:] = child2[s:], child1[s:]  # меняем части хромосом

# мутация


def mutFlipBit(mutant, indpb=0.01):  # indpb - вероятность мутации отдельного гена
    for indx in range(len(mutant)):
        if random.random() < indpb:
            mutant[indx] = 0 if mutant[indx] == 1 else 1  # инверсия бита


# список состоит из значений приспособленностей данной популяции
fitnessValues = [individual.fitness.values[0] for individual in population]


while max(fitnessValues) < ONE_MAX_LENGTH and generationCounter < MAX_GENERATIONS:
    generationCounter += 1
    offspring = selTournametnt(population, len(population))
    offspring = list(map(clone, offspring))

# выбираем чётную и нечётную особь и формируем потомков - скрещивание
    for child1, child2 in zip(offspring[::2], offspring[1::2]):
        if random.random() < P_CROSSOVER:
            cxOnePoint(child1, child2)

    for mutant in offspring:
        if random.random() < P_MUTATION:
            mutFlipBit(mutant, indpb=1.0/ONE_MAX_LENGTH)

# обновляем значения приспособленности особей новой популяции
    freshFitnessValues = list(map(oneMaxFitness, offspring))
    for individual, fitnessValue in zip(offspring, freshFitnessValues):
        individual.fitness.values = fitnessValue
# обновляем список популяции
    population[:] = offspring
# обновляем значения приспособленностей каждой особи в популяции
    fitnessValues = [ind.fitness.values[0] for ind in population]
# формируем статистику
    maxFitness = max(fitnessValues)
    meanFitness = sum(fitnessValues) / len(population)
    maxFitnessValues.append(maxFitness)
    meanFitnessValues.append(meanFitness)
    print(
        f"Поколение {generationCounter}: Макс приспособленность = {maxFitness}, Средняя приспособленность = {meanFitness}")

    # индекс лучшего индивидуума
    best_index = fitnessValues.index(max(fitnessValues))
    # вывод хромосомы лучшего индивидуума
    print("Лучший индивидуум = ", *population[best_index], "\n")

plt.plot(maxFitnessValues, color='red')
plt.plot(meanFitnessValues, color='green')
plt.xlabel('Поколение')
plt.ylabel('Макс/средняя приспособленность')
plt.title('Зависимость максимальной и средней приспобленности от поколения')
plt.show()
