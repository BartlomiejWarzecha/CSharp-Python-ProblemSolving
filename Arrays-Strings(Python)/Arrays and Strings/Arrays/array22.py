

def minimumSwaps(a,n):
    swap = 0

    expectedFirst = 1
    expectedSecond = 2
    expectedThird = 3

    for i in range(n):
        if(a[i] == expectedFirst):
            expectedFirst += expectedSecond
            expectedSecond += expectedThird
            expectedThird += 1
            
        if(a[i] == expectedSecond):
            swap += 1
            expectedFirst = expectedSecond
            expectedSecond = expectedThird
            expectedThird += 1
           
        if(a[i] == expectedThird):
            swap += 2
            expectedThird += 1
            
        else:
            return swap

    return swap

t = int(input())
end = []
for i in range(t):    
    n = int(input())
    a = list(input().split()) 

    for k in range(0, len(a)): 
        a[k] = int(a[k])

    end.append(minimumSwaps(a, n))

for i in end:
    print(i)