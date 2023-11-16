x = int(input())
y = int(input())
z = int(input())
if x > 0 and y > 0 and z > 0:
    print(1)
else:
    if x > 0 and y <0 and z > 0:
        print(4)
    else:
        if x < 0 and y > 0 and z > 0:
            print(2)
        else:
            if x < 0 and y > 0 and z > 0:
                print(3)
            else:
                if x > 0 and y > 0 and z < 0:
                    print(5)
                else:
                    if x > 0 and y < 0 and z < 0:
                        print(8)
                    else:
                        if x < 0 and y > 0 and z < 0:
                            print(6)
                        else:
                            if x < 0 and y > 0 and z < 0:
                                print(7)
                            else:
                                print("На координатной прямой")