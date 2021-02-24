

T = int(input())

for i in range(T):

    n = int(input())

    a = list(input().split())

    for i in range(0, len(a)): 
        a[i] = int(a[i])

    maxi = 0 

    for i in range(n):
        for j in range(n-1):
            v = abs((j) - i) + abs(a[i] - a[j])
            if(v > maxi):
                maxi = v
    
    print(maxi)


    