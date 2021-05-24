T = int(input())

while(T):

    array = list(input().split())

    for i in range(0, len(array)): 
        array[i] = int(array[i])

    l = array[0]
    r = array[1]
    prime = r - l 

    for i in range(l, r + 1):
        for j in range(2, i):
            if(i % j == 0):
                prime -= 1
                break
    
    composite = (r - l) - prime

    suma = composite * (prime + 1)
    print(suma)

    T -= 1