def split(word): 
    return [char for char in word]  
    

print("Jak masz na imię?")
imie = input()

split(imie)


# for i in range(1, 2*len(imie)):
   # if(i % 2 == 0):imie[i] += ("3") 


print(imie)
print(len(imie))


for i in range(len(imie)):