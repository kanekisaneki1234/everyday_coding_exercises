function isValid(input: string): boolean {
    const openings: string[] = [];
    const mappings = new Map<string, string>([
        [']', '['],
        ['}', '{'],
        [')', '(']
    ]);

    for (const c of input) {
        if(c==='{' || c==='[' || c==='(') openings.push(c);
        else {
            if (openings.length===0) return false;

            if (openings.at(-1)!=mappings.get(c)) return false;

            openings.pop();
        }
    }
    return (openings.length===0);
}

console.log(isValid("{{[]}}"))