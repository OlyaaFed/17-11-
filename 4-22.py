z, x, c, u = int(input()), int(input()), int(input()), int(input())
if abs(z - c) == 2 and abs(x - u) == 1 or abs(z - c) == 1 and \
abs(x - u) == 2:
 print("YES")
else:
 print("NO")