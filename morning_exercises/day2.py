# def palindrome(num):
#     try:
#         int(num)
#     except Exception as e:
#         print("Not a number:", e)
#         return

#     pal_check = ""
#     temp_num = num

#     for i in range(0,len(num)):
#         last_digit=int(temp_num)%10
#         pal_check+=str(last_digit)
#         temp_num = int(temp_num) // 10
#         print(last_digit, pal_check, temp_num)

#     if pal_check==num: return True
#     else: return False

# print(palindrome("100"))

def palindrome_num_approach(num):
    try:
        int(num)
    except Exception as e:
        print("Not a number:", e)
        return
    
    if num < 0:
        return False

    pal_check = 0
    temp_num = num

    while temp_num>0:
        last_digit=temp_num%10
        pal_check=pal_check*10+last_digit
        temp_num = temp_num // 10
        print(last_digit, pal_check, temp_num)

    if pal_check==num: return True
    else: return False

print(palindrome_num_approach(111))