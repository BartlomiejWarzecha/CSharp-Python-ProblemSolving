# Python program to print the list items containing all 
# characters of a given word 
NO_OF_CHARS = 256
  
# Prints list items having all characters of word 
def printList(list, word, list_size): 
    map = [0] * NO_OF_CHARS 
  
    # Set the values in map 
    for i in word: 
        map[ord(i)] = 1
  
    # Get the length of given word 
    word_size = len(word) 
  
    # Check each item of list if has all characters 
    # of words 
    for i in list: 
        count = 0
        for j in i: 
            if map[ord(j)]: 
                count+=1
  
                # unset the bit so that strings like sss 
                # not printed 
                map[ord(j)] = 0
        if count==word_size: 
            print(i)  
  
        # Set the values in map for next item 
        for j in range(len(word)): 
            map[ord(word[j])] = 1

# Driver program to test the above function 

string = "gun"
list = ["geeksforgeeks", "unsorted", "sunday", "just", "sss", "mpknug"] 
printList(list, string, 6) 
  
# This code is contributed by Bhavya Jain 