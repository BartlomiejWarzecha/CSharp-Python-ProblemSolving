
def equilibrium(a, n):
    point = -2

    suma_1 = 0
    suma_2 = 0

    x = 0

    j = len(a)

    if(len(a) == 1):
        point = 1

    if((len (a)) != 1):
        k = len(a) - 1
        x = 0
        
        suma_1 += a[x]
        suma_2 += a[k]

        for i in range(j):

            if(suma_2 < suma_1):
                k -= 1
                suma_2 += a[k]

            if(suma_2 > suma_1):
                x += 1
                suma_1 += a[x]

            if(suma_1 == suma_2 and x + k == n-1):
                point = x + 1
                break

    print(point+1)

T = int(input())

for i in range(T):
    N = int(input())
    array = list(input().split())

    for i in range(0, len(array)): 
        array[i] = int(array[i])
    equilibrium(array,N)
