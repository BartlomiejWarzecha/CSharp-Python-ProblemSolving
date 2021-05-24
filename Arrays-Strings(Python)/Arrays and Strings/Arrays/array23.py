# Complete the minimumSwaps function below.
def minimumSwaps(arr):
    #principle: trying to swap with maximum impact
    #iterations (reads) are cheap, swapping expensive
    #if two values can be swapped where both receive terminal position afterwards, perfect
    swaps = 0
    min = None
    for i in arr:
        if min is None or min > i:
            min = i
    #defined a min, which is at 0, let's make sure it's at i=0
    min_i = arr.index(min)
    if min_i is not 0:
        swap(arr, 0, min_i)
        swaps+=1
    
    #because the minimum is at 0 and they are all consecutive, it's basically an offset
    offset = arr[0]
    
    #initializing a dict copy that keeps track of the locations for quick find and swap
    index_dict = {v: i for i,v in enumerate(arr)}
    #starting at 1, 0 is already placed
    i = 0
    while i < len(arr)-1:
        i += 1
        if not proper_place(arr, i, offset):
            try:
                val = arr[i]
                #testing for perfect swap
                if arr[val - offset-1] == i:
                    swap(arr, i, val - offset)
                    swaps+=1
                #no perfect swap possible, find item that belongs here and swap this one away
                else:
                    j = index_dict[i+offset]
                    index_dict[arr[i]] = j
                    swap(arr, i, j)
                    
                    swaps+=1
            except:
                pass
    return swaps
                
            
        
def proper_place(arr, i, min):
    return arr[i] - min == i

def swap(arr, a, b):
    t = arr[a]
    arr[a] = arr[b]
    arr[b] = t

n = int(input())
a = list(input().split()) 

for k in range(0, len(a)): 
    a[k] = int(a[k])

print(minimumSwaps(a))