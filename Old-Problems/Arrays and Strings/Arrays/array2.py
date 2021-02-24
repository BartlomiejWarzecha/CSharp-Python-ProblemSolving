
def triplets(a):
    suma = 0
    x = 0

    triplets = 0
    for i in range(len(a)):
        j = len(a) - 1
        k = i + 1
        while(j > k):
            if(a[j] + a[k] == a[i]):
                triplets += 1 
                j -= 1
                k += 1
            if(a[j] + a[k] < a[i]):
                j -= 1
            else:
                k += 1

    if(triplets != 0):
        print(triplets)
    else:
        print(-1)

T = int(input())

for i in range(T):
    N = int(input())
    array = list(input().split())

    for i in range(0, len(array)): 
        array[i] = int(array[i])
    #Decreasing
    array.sort(reverse = True)
    triplets(array)