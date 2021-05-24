for T in range(int(input())):

    n = int(input())
    a = list(map(int,input().split()))
# Lewa Ściana    
    lmax=a[0]
# Prawa Ściana
    rmax=max(a[1:])

    count=0

    for i in range(n):
        # sprawdzamy od lewej czy znaleźliśmy większą granice 
        if(a[i]>lmax):
            lmax=a[i]
        # szukamy najwyższej prawej granicy ściany z pozostałych wartości 
        if(a[i]==rmax and i<n-1):
            rmax=max(a[i+1:])

        # Sprawdzamy która granica jest mniejsza
        h=min(lmax,rmax)
        
        #Dodajemy do licznika różnice najmniejszej granicy z polem do którego się odnosimy, w przypadku gdyby granica była więk
        count+=max(h-a[i])
    print(count)    