
def split(word): 
    return [char for char in word]


string = str(input())
S = split(string)

suma = 1

for i in range(len(S)):
    if(S[i] == "["):
        suma += 1
    if(S[i] == "]"):
        suma -= 1 
    if(S[i] == "{"):
        suma += 1
    if(S[i] == "}"):
        suma -= 1 
    if(S[i] == ")"):
        suma += 1
    if(S[i] == "("):
        suma -= 1 
    

if(suma == 1):
    print("Balanced")
else:
    print("Not Balanced")

    
