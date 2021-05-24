
# Pierwsza próba

T = int(input())

for t in range(T):
    n = int(input())
    a = list(input().split())

    for i in range(0, len(a)):
        a[i] = int(a[i])

    p = a[0]
    k = a[n-1]
    poziom = 0
    wynik = 1
    z = 0

    for i in range(n-2):
        k = i + 1
        for j in range(n - 2 - k):
            l = k + 1 + j
            if(a[l] >= a[k] and a[k] <= a[0]):
                z = 1
            else:
                z = 0
        if(z):
            poziom = a[k]
            koniec = k
            wynik = (n-2) * poziom
            break

    for c in range(koniec - 1):
        k = c + 1
        
        if(a[k] < poziom):
            wynik -= a[k]


    print(wynik)