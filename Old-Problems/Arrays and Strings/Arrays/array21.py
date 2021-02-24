def check(a,n, prawidlowa):
    
    prawidlowa = []

    for d in range(n):
        prawidlowa.append(d+1)


    for i in range(n):        
        g = 0
        for j in range(n):
            if(prawidlowa[i] == a[j]):
                g = abs(i-j)
                continue
        if(g > 2):
            return 0
    return 1


def rot(a, i, j):

    if(abs(i - j) == 2):
        temp = a[j]
        a[j] = a[i+1]
        a[i+1] = temp

        temp = a[i]
        a[i] = a[j]
        a[i+1] = temp

        return 2

    else:
        temp = a[i]
        a[i] = a[j]
        a[i+1] = temp

        return 1

def fullRotate(p,a,n):

    wynik = 0 

    for i in range(n):
        if(p[i] != a[i]):
            for j in range(n):
                if(p[i] == a[j]):
                   wynik += rot(a, i, j) 

    return wynik
    

T = int(input())

end = []
while(T):

    n = int(input())
        
    prawidlowa = []

    for d in range(n):
        prawidlowa.append(d+1)

    a = list(input().split()) 
    for k in range(0, len(a)): 
        a[k] = int(a[k])
    
    if(check(a, n, prawidlowa)):
        end.append(fullRotate(prawidlowa, a, n))
    else:
        end.append("Too chaotic")

    T -= 1

for i in end:
    print(i)



