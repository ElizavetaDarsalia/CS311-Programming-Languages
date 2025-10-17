n = int(input("Enter number: "))
parts = []
for i in range(1, n + 1):
    if i % 3 == 0 and i % 5 == 0:
        parts.append("FizzBuzz")
    elif i % 3 == 0:
        parts.append("Fizz")
    elif i % 5 == 0:
        parts.append("Buzz")
    else:
        parts.append(str(i))
print(" ".join(parts))

