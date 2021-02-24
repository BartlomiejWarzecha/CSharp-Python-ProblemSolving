# Python program to check if given string is an interleaving of 
# the other two strings 
  
# Returns true if C is an interleaving of A and B, otherwise 
# returns false 
def isInterleaved(A, B, C): 
  
    # Utility variables 
    i = 0
    j = 0
    k = 0
  
    # Iterate through all characters of C. 
    while k != len(C)-1: 
  
        # Match first character of C with first character of A, 
        # If matches them move A to next 
        if i<len(A) and A[i] == C[k]: 
            i+=1
  
        # Else Match first character of C with first character 
        # of B. If matches them move B to next 
        elif j< len(B) and B[j] == C[k]: 
            j+=1
  
        # If doesn't match with either A or B, then return false 
        else: 
            return 0
  
        # Move C to next for next iteration 
        k+=1
  
    # If A or B still have some characters, then length of C is 
    # smaller than sum of lengths of A and B, so return false 
    if A[i-1] or B[j-1]: 
        return 0
  
    return 1
  
# Driver program to test the above function 
A = "AB"
B = "CD"
C = "ACBD"
if isInterleaved(A, B, C) == 1: 
    print (C + " is interleaved of " + A + " and " + B)
else: 
    print (C + " is not interleaved of " + A + " and " + B)
  