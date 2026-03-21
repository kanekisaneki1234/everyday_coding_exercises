#include <iostream>
#include <vector>

bool generateSieve(int n) {
    std::vector<bool> isPrime(n+1, true);

    isPrime[0] = isPrime[1] = false;

    for (int p=2; p*p<=n; p++) {
        if (isPrime[p]==false) {
            for (int multiple = p*p; multiple<=n; multiple+=p) {
                isPrime[multiple]=false;
            }
        }
    }
    return isPrime[n];
}

void primeBuzz(int n) {
    bool isPrime = generateSieve(n);
    bool isBuzz = n%5==0;

    if (isPrime && isBuzz) std::cout << "Primebuzz\n";
    else if (isBuzz)       std::cout << "Buzz\n";
    else if (isPrime)      std::cout << "Prime\n";
    else                   std::cout << n << "\n";
}

int main() {
    primeBuzz(13);
}