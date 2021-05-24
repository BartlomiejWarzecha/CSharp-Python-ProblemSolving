

def split(word): 
    return [char for char in word]

T = int(input())

def anagram(str1, str2):
    x = 0
    if(len(str1) == len(str2)):
        for i in range(len(str1)):
            if(str1[i] == str2[i]):
                x = 1
            else: 
                x = 0

    return x

while(T):

    string = input()
    s = string.split(' ')    

    b = s[0]
    a = s[1]

    x = a
    a = split(b)
    b = split(x)

    a.sort()
    b.sort()

    if(anagram(a,b)):
        print("YES")
    else:
        print("NO")



    T -= 1