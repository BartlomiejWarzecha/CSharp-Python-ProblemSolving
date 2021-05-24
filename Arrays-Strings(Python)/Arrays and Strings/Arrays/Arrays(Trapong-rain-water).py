
def ostatni(n, a):

    #! Lewa granica
    x = 0
    #! srodek opadu
    s = 1
    #! prawa granica
    cage = 0 

    #! ilość kolumn w środku
    column = 0

    punkty = 0
    punktyKoncowe = 0

    for i in range(n-1):
        if(a[i] > a[i+1]):
            cage = 1
            for k in range(n-1-i):
                j = i + 1
                if(a[j] < a[j+1] and a[j+1] < a[i]):
                    punkty -= a[j]
                    if(a[j+2])
                    continue
                    
        if(a[x] > a[s] and a[y] >= a[s]):

            column += 1            
            punkty -= a[s]
            s += 1
            y = s + 1
            # print(punkty)
            continue
        
        
        if(a[s] > a[y]):

            if(a[x] >= a[y]):
                #print(1)
                punktyKoncowe +=  column * a[y]  + punkty
                punkty = 0
                
                x += y - 1
                s += 1
                y = s + 1 
                
                column = 0
                print(x)
                print(s)
                print(y)
                
        if(y == n-1):
            break

    print(punktyKoncowe)
            

T = int(input())

for t in range(T):
    n = int(input())
    a = list(input().split())

    for i in range(0, len(a)):
        a[i] = int(a[i])

    ostatni(n, a)