#generate numbers
def generateNumList(maxNum):
	n = 0
	nList = []
	while n < maxNum:
		n += 1
		nList.append(n)
	return nList

def squareDigits(input):
	squareDigits = []
	for i in input:
		sqDig = int(i) * int(i)
		squareDigits.append(sqDig)
	return squareDigits

def sumSquares(sqDig):
	sumSq = sum(sqDig)
	return sumSq

#main function		
def mainFunction(input): #input = number to evaluate
	#call square input digits
	sqDig = squareDigits(str(input))
	
	#call sum square digits
	sumSq = sumSquares(sqDig)
		
	#recall mainFunction if new input is > 1 and != 4
	if sumSq == 1:
		happyNumbers.append(i)
	elif sumSq > 1 and sumSq != 4:
		mainFunction(sumSq)
	
happyNumbers = []

nList = generateNumList(100)
while len(happyNumbers) < 20:
	for i in nList:
		mainFunction(i)

print happyNumbers