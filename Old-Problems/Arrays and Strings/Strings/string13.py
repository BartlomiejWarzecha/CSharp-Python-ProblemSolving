
def split(word): 
    return [char for char in word]


string = input()
a = split(string)
string = input()
b = split(string)


for i in range(len(a)):
    k = 0
    for j in range(len(b)):
        if(i + len(b) <= len(a)):
            if(a[i + k] == a[k]):
                k += 1
            else:
                break
            if(k == len(b)):
                print('Pattern found at index', i)
                break





