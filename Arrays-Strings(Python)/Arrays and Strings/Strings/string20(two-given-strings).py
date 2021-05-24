
def split(word): 
    return [char for char in word]




#Your task is to complete this Function \
#function should return True/False
def isInterleave(A, B, C):
    
    if(A + B == C):
        return True
    if(B + A == C):
        return True
    else: 
        return False

string = str(input())
s1 = split(string)

string = str(input())
s2 = split(string)

string = str(input())
s3 = split(string)




if(isInterleave(s1, s2, s3)):
   print("True")
else:
   print("False")