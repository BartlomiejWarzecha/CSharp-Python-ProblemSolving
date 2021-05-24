
# Python3 program to reverse a string 
# s = input() 
s = "i like this program very much"
words = s.split(' ') 
string =[] 
for word in words: 
    string.insert(0, word) 
  
print("Reversed String:") 
print(" ".join(string)) 
  
# Solution proposed bu Uttam 