import math

def isPerfSquare(n: int)->bool:
    root = int(math.sqrt(n))

    return ((root*root)==n)

def isFib(n: int)->bool:
    if (n<0): return False

    return (isPerfSquare((5*n*n)+4) or isPerfSquare((5*n*n)-4))

def fibBuzz(n: int)->None:
    for i in range(1,n+1):
        fib=isFib(i)
        buzz=(i%7==0)
        fibbuzz=(fib and buzz)
        if (fibbuzz): print("FibBuzz")
        elif (fib): print("Fib")
        elif (buzz): print("Buzz")
        else: print(i)

fibBuzz(21)