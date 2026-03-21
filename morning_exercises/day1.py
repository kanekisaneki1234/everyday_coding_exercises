"""
Write a function primebuzz(n) that prints numbers from 1 to n, but:

Print "Prime" if the number is prime
Print "Buzz" if the number is divisible by 5
Print "PrimeBuzz" if it's both (a prime divisible by 5)
Otherwise, print the number itself

Example Output (n=15)
"""

def sieve(n):
    is_prime = [True]*(n+1)
    is_prime[0]=is_prime[1]=False

    for p in range(2, int(n**0.5)+1):
        if(is_prime[p]):
            for multiple in range(p*p, n+1, p):
                is_prime[multiple]=False

    return is_prime[n]

def primebuzz(n):
    if ((n%5==0) and (sieve(n)==True)):
        print("PrimeBuzz")
    elif ((n%5==0) and (sieve(n)==False)):
        print("Buzz")
    elif(sieve(n)==True):
        print("Prime")

primebuzz(5)