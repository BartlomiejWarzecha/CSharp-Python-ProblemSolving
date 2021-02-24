
def sort(a):
    counter_0 = 0
    counter_1 = 0
    counter_2 = 0

    for i in range(len(a)):
        if(a[i] == 0):
            counter_0 += 1
        if(a[i] == 1):
            counter_1 += 1
        if(a[i] == 2):
            counter_2 += 1
    for i in range(len(a)):
        if(counter_0 > 0):
            a[i] = 0
            counter_0 -= 1
            continue
        if(counter_1 > 0):
            a[i] = 1
            counter_1 -= 1
            continue
        if(counter_2 > 0):
            a[i] = 2
            counter_2 -= 1
            continue
    for i in a:
        print(i, end = " ")


T = int(input())

for i in range(T):
    N = int(input())
    array = list(input().split())

    for i in range(0, len(array)): 
        array[i] = int(array[i])

    sort(array)
