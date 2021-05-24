
T = int(input())

for i in range(T):

    n = int(input())

    a = list(input().split())

    for i in range(0, len(a)): 
        a[i] = int(a[i])

    beautiful = 0 
    r = 0
    l = 0
    for i in range(n):
        k = n-i-1
        for j in range(k):
            if(a[k] < a[k-1]):
                r += 1

            if(a[k] >= a[k-1]):
                l += 1

                if(l == r):
                    beautiful +=1
            
    print(beautiful)

    

    