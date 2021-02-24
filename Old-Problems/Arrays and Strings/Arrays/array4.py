
def lost(a,n):
    if(a[0] == 2):
        wynik = 1
    else:
        if(len(a) < n):
            wynik = a[len(a) - 1] + 1
        else:
            wynik = a[0] + 1
            
    for i in range(len(a) - 1):
        if(a[i] + 1 < a[i+1]):
            wynik = a[i] + 1
    print(wynik)

# Python program for implementation of Bubble Sort 
  
  

T = int(input()) 
for i in range(T):
    N = int(input())
    array = list(input().split())

    for i in range(0, len(array)): 
        array[i] = int(array[i])

    array.sort()
    lost(array,N)