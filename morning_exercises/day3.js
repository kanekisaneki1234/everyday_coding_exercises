"use strict";
function isPerfectSquare(n) {
    const root = Math.floor(Math.sqrt(n));
    return root * root === n;
}
function isFib(n) {
    if (n < 0)
        return false;
    return (isPerfectSquare((5 * n * n) + 4) || isPerfectSquare((5 * n * n) - 4));
}
function fibBuzz(n) {
    for (let i = 1; i <= n; i++) {
        if ((isFib(i) === true) && (i % 7 === 0))
            console.log("FibBuzz");
        else if ((isFib(i) === true) && (i % 7 != 1))
            console.log("Fib");
        else if ((isFib(i) === false) && (i % 7 === 0))
            console.log("Buzz");
        else
            console.log(i);
    }
}
fibBuzz(21);
//# sourceMappingURL=day3.js.map