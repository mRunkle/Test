numbers = [8, 12, 23, 34, 45, 350, 4378, 12000]

sepDigits = []
for i in numbers:
	i = map(int, str(i))
	sepDigits.append(i)

print sepDigits

for i in sepDigits:
	if len(i) == 1:
		print (i[0] * i[0])
	elif len(i) == 2:
		print (i[0] * i[0]) + (i[1] * i[1])
	elif len(i) == 3:
		print (i[0] * i[0]) + (i[1] * i[1]) + (i[2] * i[2])
	elif len(i) == 4:
		print (i[0] * i[0]) + (i[1] * i[1]) + (i[2] * i[2]) + (i[3] * i[3])
	else:
		print "More than four digits"
		
#while len(sepDigits) > 1:
	