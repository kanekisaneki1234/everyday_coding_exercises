function generateSieve(n) {
    let isPrime = new Array(n+1).fill(true);
    isPrime[0] = isPrime[1] = false;

    for(let p=2; p*p<=n; p++) {
        if(isPrime[p]) {
            for (let multiple=p*p; multiple<=n; multiple+=p) {
                isPrime[multiple]=false;
            }
        }
    }
    return isPrime[n];
}

function primeBuzz(n) {
    let isPrime = generateSieve(n);
    let isBuzz = n%5 === 0;

    if (isPrime && isBuzz) console.log("Primebuzz");
    else if (isBuzz) console.log("Buzz");
    else if (isPrime) console.log("Prime");
    else console.log(n);
}

primeBuzz(23)