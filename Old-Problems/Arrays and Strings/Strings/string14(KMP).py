
def split(word): 
    return [char for char in word]

T = int(input())

def find(s):

    goodValues = True
    allsame = True
    ls = len(s)
    x = 0

    for i in range(ls-1):
        if(a[0] == a[i+1]):
            x = i + 1
            for j in range(ls):
                if(x + 1 + j < ls):
                    if(a[1 + j] == a[x + 1 + j]):
                        goodValues = True
                        continue
                    else:
                        goodValues = False
                        break
            if(goodValues):
                x = i + 1
            else:
                x = 0
        else:
            allsame = False
    
    if(allsame):
        return ls -1
    else:
        return x


while(T):

    string = str(input())
    a = split(string)
    la = len(a)
    k = 0 
    x = 0
    split = find(a)
    print(split)


#     for i in range(la)):
        # for j in range(la):
            # if(a[i+j] == a[la - j]):




                    
    T -= 1

