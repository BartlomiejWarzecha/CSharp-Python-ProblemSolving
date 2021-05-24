# Python program for A modified Naive Pattern Searching 
# algorithm that is optimized for the cases when all 
# characters of pattern are different 
def search(pat, txt): 
    M = len(pat) 
    N = len(txt) 
    i = 0
  
    while i <= N-M: 
        # For current index i, check for pattern match 
        for j in range(M): 
            if txt[i+j] != pat[j]: 
                break
            j += 1
  
        if j==M:    # if pat[0...M-1] = txt[i,i+1,...i+M-1] 
            print("Pattern found at index " + str(i)
            i = i + M 
        elif j==0: 
            i = i + 1
        else: 
            i = i+ j    # slide the pattern by j 
  
# Driver program to test the above function 
txt = "ABCEABCDABCEABCD"
pat = "ABCD"
search(pat, txt) 
  
# This code is contributed by Bhavya Jain 
