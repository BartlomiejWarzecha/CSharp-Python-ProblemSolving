def split(word): 
    return [char for char in word]  

T = int(input())

while(T):
    # checking if case is true

    isit = False

    array_1 = input() 
    a = split(array_1)

    for i in range(len(a)):
        if(a[i] != 'R' and a[i] != 'Y'):
            isit = False 
            break
        if(i == 0 and a[i] == 'Y'):
            isit = False
            break
        if(i >= 2):
            if(a[i] == 'Y' and (a[i-1] != 'R' and a[i-2] != 'R')):
                isit = False
                break
        isit = True
    
    if(isit):
        print("YES")
    else:
        print("NO")



    T -= 1


    