

def encode(string):

    secoundstring = ''

    for i in range(2*len(string)):
        secoundstring +=  str(i) 

    count = 0
    j = 0

    for i in range(len(string)-1):

        count  += 1        
        
        if(string[i] == string[i+1]):
            count += 1
        else:   
            secoundstring[j] += string[i] 
            strc = count 
            j += 1
            secoundstring[j] += str(strc)
            count = 0

    print(secoundstring)


str = 'aaaabbbccc'

encode(str)