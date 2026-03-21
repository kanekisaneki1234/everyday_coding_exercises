def isValid(input: str)->bool:
    openings = []
    mappings = {
        '}':'{',
        ']':'[',
        ')':'('
    }
    
    for c in input:
        if c in mappings.values(): openings.append(c)

        else:
            if len(openings)==0: return False

            if (openings[-1]!=mappings[c]): return False

            openings.pop()

    return len(openings)==0

print(isValid("{[()]}"))
