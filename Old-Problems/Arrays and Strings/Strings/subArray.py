
def subArray(a,s,p):
    if(p == a):
        return -1
    else:
        suma = 0
        k = len(a)
        j = p
    for i in range(k-p):
        suma += a[j]
        if(suma == s):
            print(p + 1, i + 1 + p)
            break
        if(suma > s):
            return subArray(a,s,p+1)
        j += 1    
array = {} 

T = int(input())
for i in range(T):
    N,S = input().split()
    N = int(N)
    S = int(S)
    array = list(input().split())

    for i in range(0, len(array)): 
        array[i] = int(array[i]) 

    subArray(array,S,0)
