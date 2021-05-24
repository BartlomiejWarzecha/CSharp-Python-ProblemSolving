array = list(input().split())
left = 0
right = 0

def split(word): 
    return [char for char in word]  

array = list(input().split())
left = 0
right = 0

print(split(word)) 


for i in range(len(array)):
    if(array[i] == "("):
        left += 1
    if(array[i] == ")"):
        right += 1

if(left == right):
    print(left)
if(left > right):
    print(right)
if(right > left):
    print(left)