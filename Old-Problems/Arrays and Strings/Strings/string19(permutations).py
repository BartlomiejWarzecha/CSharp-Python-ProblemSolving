
def split(word): 
    return [char for char in word]

    string = str(input())
    S = split(string)
    N = len(S)

    for i in range(N):
        for j in range(N):
            
    

# Python program to print all permutations with repetition 
# of characters 
  
def toString(List): 
    return ''.join(List) 
  
# The main function that recursively prints all repeated 
# permutations of the given string. It uses data[] to store 
# all permutations one by one 
def allLexicographicRecur (string, data, last, index): 
    length = len(string) 
  
    # One by one fix all characters at the given index and 
    # recur for the subsequent indexes 
    for i in xrange(length): 
  
        # Fix the ith character at index and if this is not 
        # the last index then recursively call for higher 
        # indexes 
        data[index] = string[i] 
  
        # If this is the last index then print the string 
        # stored in data[] 
        if index==last: 
            print toString(data) 
        else: 
            allLexicographicRecur(string, data, last, index+1) 
  
# This function sorts input string, allocate memory for data 
# (needed for allLexicographicRecur()) and calls 
# allLexicographicRecur() for printing all permutations 
def allLexicographic(string): 
    length = len(string) 
  
    # Create a temp array that will be used by 
    # allLexicographicRecur() 
    data = [""] * (length+1) 
  
    # Sort the input string so that we get all output strings in 
    # lexicographically sorted order 
    string = sorted(string) 
  
    # Now print all permutaions 
    allLexicographicRecur(string, data, length-1, 0) 
  
# Driver program to test the above functions 
string = "ABC"
print "All permutations with repetition of " + string + " are:"
allLexicographic(string) 
  
# This code is contributed to Bhavya Jain 