
T = int(input()) 
while(T):
    wynik = -1
    N = int(input())
    array = list(input().split())
    check = 0
    for i in range(0, len(array)): 
        array[i] = int(array[i])

    for i in range(len(array)-1):
        if(array[i] < array[i+1]):
            k = array[i+1]
            for j in range( i + 2, len(array)):
                if(k <= array[j]):
                    wynik = k
                    check += 1
                else:
                    check = 0
                    wynik = -1
                    break
        if(check > 0):
            break
    print(wynik)

    T -= 1