a = int(input())
b = int(input())
c = int(input())
if b > a:
    a, b = b, a
if c > b:
    b, c = c, b
if a > c:
    a, c = c, a
print(a, b, c)