# #### 1.2[4]. Петя, Катя и Сережа делают из бумаги журавликов. Вместе они сделали
#  ```S``` журавликов. Сколько журавликов сделал каждый ребенок, если известно, что
#  Петя и Сережа сделали одинаковое количество журавликов, а Катя сделала в два раза 
# больше журавликов, чем Петя и Сережа вместе?

# 	Примеры/Тесты:
# 	6 >>>  1  4  1
# 	24 >>> 4  16  4
# 	60 >>> 10  40  10
totalNumberOfCranes = 24
x = numberOfPeterCranes = numberOfSergeyCranes = 0
numberOfKateCranes = 4*x
x = totalNumberOfCranes//6
numberOfKateCranes = 4 * x
print("{} {} {}".format(x,numberOfKateCranes,x))
