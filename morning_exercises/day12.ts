function binarySearch(input: number[], left: number, right: number, val: number): number {
    if (left>right) return -1;
    let mid: number = Math.floor((left+right)/2);
    if (val===input[mid]) return mid;
    else if (val<input[mid]) return binarySearch(input, left, mid-1, val);
    return binarySearch(input, mid+1, right, val);
}

{
    let input = [2,4,7,9,13,17];
    console.log(binarySearch(input, 0, input.length-1, 7));
}