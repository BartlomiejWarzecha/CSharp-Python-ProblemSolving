
def ostatni(n, a):

    p = a[0]
    najw_punktow = 0
    punkty = 0
    for i in range(n-1):
        k = i + 1
        if(i > 0):
            koniec = k
            if(a[0] > a[koniec]):
                poziom = a[koniec]
            else:
                poziom = a[0]
            k -= 1
            punkty = 0

            while(k):
                
                punkty += poziom - a[k]
               
                if(punkty > najw_punktow):
                    najw_punktow = punkty

                k -= 1

            for j in range(n - k  + 1):
                l = k + 1
                d = j + 1
                if(j > 0):
                    koniec = l
                    if(a[0] > a[koniec]):
                        poziom = a[koniec]
                    else:
                        poziom = a[0]
                    l -= 1
                    punkty = najw_punktow
                    

    print(najw_punktow)
            

T = int(input())

for t in range(T):
    n = int(input())
    a = list(input().split())

    for i in range(0, len(a)):
        a[i] = int(a[i])

    # koniec = ostatni(n,a)
    # poziom = 0

    # if(a[0] > a[koniec]):
        # poziom = a[koniec]
    # else:
        # poziom = a[0]

    # wynik = 1 * (koniec - 1) * poziom

    # for i in range(koniec - 1):
        # j = i + 1

        # if(a[j] > poziom):
            # a[j] = poziom

        # wynik -= a[j]

    ostatni(n, a)