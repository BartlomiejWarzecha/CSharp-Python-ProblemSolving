
def equilibrium(a,n):

    point = -1

    suma_1 = 0
    suma_2 = 0

    if(len(a) == 1):
        point = 1

    if((len (a)) != 1):

        for i in range(n):
            k = i
            while(k < n):
                suma_1 += a[k]
                k += 1
            for j in range(i):
                suma_2 += a[j]
            if(suma_1 == suma_2):
                point = i+1

    print(point)

T = int(input())

for i in range(T):
    N = int(input())
    array = list(input().split())

    for i in range(0, len(array)): 
        array[i] = int(array[i])
    equilibrium(array,N)
