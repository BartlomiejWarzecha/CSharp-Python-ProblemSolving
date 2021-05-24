
T = int(input())

while(T):

    count = 0
    l = list(input().split())

    for i in range(0, len(l)): 
        l[i] = int(l[i])

    n = l[0]


    a = l[1]
    b = l[2]
    c = l[3]
    for i in range(n):
        j = i+1
        if(j % a == 0 and  j % b != 0 and j % c != 0 ):
            count += 1
        if(j % a != 0 and  j % b == 0 and j % c != 0 ):
            count += 1
        if(j % a != 0 and  j % b != 0 and j % c == 0 ):
            count += 1
    T -= 1
    print(count)