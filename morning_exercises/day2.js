function isPalindrome(n) {
    if (typeof(n)!= "number" || !Number.isInteger(n)) throw new Error("Input must be an integer");

    if (n<0) return false;

    let checkPal=0, temp=n;

    while (temp>0) {
        let lastDigit = temp%10;
        checkPal=checkPal*10+lastDigit;
        temp=Math.floor(temp/10);
    }
    return checkPal===n;
}

console.log(isPalindrome(10));