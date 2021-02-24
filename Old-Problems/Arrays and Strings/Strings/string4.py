
def split(word): 
    return [char for char in word]

def value(x):
    if(x == "I"):
        return 1  
    if(x == "V"):
        return 5  
    if(x == "X"):
        return 10  
    if(x == "L"):
        return 50  
    if(x == "C"):
        return 100  
    if(x == "D"):
        return 500  
    if(x == "M"):
        return 1000

def getRoman(x):
        n = len(x)

        suma  = 0

        for i in range(n):
            if(i == n-1):
                suma += value(x[i])
                return(suma)
                break
            else:
                y = value(x[i])
                z = value(x[i+1])
                if(y >= z):
                    suma += y
                else:
                    suma -=y 

        return suma


T = int(input())

while(T):

    string = input()
    a = split(string)

    print(getRoman(a))

    T -= 1