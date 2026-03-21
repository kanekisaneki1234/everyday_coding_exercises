#include <cmath>
#include <iostream>
#include <ostream>
// #include <vector>

bool isFib(int n) {
    if (n < 0) return false;

    int root1 = (int)std::sqrt((5*n*n)+4);
    int root2 = (int)std::sqrt((5*n*n)-4);

    if (((5*n*n)+4)==root1*root1 || (((5*n*n)-4)==root2*root2)) return true;
    else return false;
}

void fibBuzz(int n) {
    for (int i=1;i<=n;i++) {
        if (isFib(i)==true && i%7!=0) std::cout << "Fib" << std::endl;
        else if (isFib(i)==true && i%7==0) std::cout << "FibBuzz" << std::endl;
        else if (isFib(i)==false && i%7==0) std::cout << "Buzz" << std::endl;
        else std::cout << i << std::endl;
    }
}

int main() {
    fibBuzz(10);
}