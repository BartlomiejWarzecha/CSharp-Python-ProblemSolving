def split(word): 
    return [char for char in word]  

T = int(input()) 
for i in range(T):
    N = int(input())
    array = input()
    splitArray = split(array)

    k = N - 1
    palindorome = True
    for i in range(N):
        if(k <= i):
            break
        if(splitArray[i] == splitArray[k]):
            k -= 1
            palindrome = True
            continue
        else:
            palindrome = False 
            break
    if(palindrome):
        print("Yes")
    else: 
        print("No")
    