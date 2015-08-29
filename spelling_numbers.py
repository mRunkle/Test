def decode_millions():
	m_id = str(number)[-7]
	m_word = ones[int(m_id) - 1]
	print m_word + " " + hundreds[2],
	decode_HUNDRED_th()

def decode_HUNDRED_th():
	if str(number)[-6] == "0":
		decode_TEN_th()
	elif str(number)[-6] != "0" and str(number)[-5] == "0" and str(number)[-4] == "0":
		hundreds_i = str(number)[-6]
		hundreds_word = ones[int(hundreds_i) - 1]
		print hundreds_word + " " + hundreds[0] + " " + hundreds[1],
		decode_hundreds()
	else:
		hundreds_i = str(number)[-6]
		hundreds_word = ones[int(hundreds_i) - 1]
		print hundreds_word + " " + hundreds[0],
		decode_TEN_th()

def decode_TEN_th():
	if str(number)[-5] == "0":
		decode_thousands()
	elif str(number)[-5] == "1" and str(number)[-4] == "0":
		print teens[0] + " " + hundreds[1],
		decode_thousands()
	elif str(number)[-5] == "1" and str(number)[-4] != "0":
		tens_i = str(number)[-4]
		tens_word = teens[int(tens_i)]
		print tens_word + " " + hundreds[1],
		decode_hundreds()
		'''	
		if str(number)[-4] == "0":
			print tens_word,
		else:
			ones_i = str(number)[-4]
			ones_word = ones[int(ones_i) - 1]
			print tens_word + "-" + ones_word,
		print hundreds[1],
		decode_thousands()
		'''
	else:
		tens_i = str(number)[-5]
		tens_word = tens[int(tens_i) - 2]
			
		if str(number)[-4] == "0":
			print tens_word,
		else:
			ones_i = str(number)[-4]
			ones_word = ones[int(ones_i) - 1]
			print tens_word + "-" + ones_word,
		print hundreds[1],
		#decode_thousands()
		decode_hundreds()

def decode_thousands():
	if str(number)[-4] == "0":
		decode_hundreds()
	else:
		thousands_id = str(number)[-4]
		id_i = int(thousands_id) - 1
		id_word = ones[id_i]
		print id_word + " " + hundreds[1],
		decode_hundreds()

def decode_hundreds():
	if str(number)[-3] == "0":
		decode_twenty_to_hundred()
	else:
		hundreds_id = str(number)[-3]
		id_i = int(hundreds_id) - 1
		id_word = ones[id_i]
		print id_word + " " + hundreds[0],
		decode_twenty_to_hundred()

def decode_twenty_to_hundred():
	if str(number)[-2] == "0":
		ones_i = str(number)[-1]
		ones_word = ones[int(ones_i) - 1]
		print ones_word
	else:
		tens_i = str(number)[-2]
		tens_word = tens[int(tens_i) - 2]
		
		if str(number)[-1] == "0":
			print tens_word
		else:
			ones_i = str(number)[-1]
			ones_word = ones[int(ones_i) - 1]
			print tens_word + "-" + ones_word

#MAIN
def mainFunction():
	#ZERO
	if number == 0:
		print "zero"

	#ONES
	elif len(str(number)) == 1:
		i = number - 1
		word = ones[i]
		print word

	#TEENS
	elif len(str(number)) == 2 and number < 20:
		i = str(number)[1]
		word = teens[int(i)]
		print word

	#TWENTY_NINETY-NINE
	elif len(str(number)) == 2:
		decode_twenty_to_hundred()

	#HUNDREDS
	elif len(str(number)) == 3:
		decode_hundreds()

	#THOUSANDS
	elif len(str(number)) == 4:
		decode_thousands()

	#TEN THOUSANDS
	elif len(str(number)) == 5:
		decode_TEN_th()

	#HUNDRED THOUSANDS
	elif len(str(number)) == 6:
		decode_HUNDRED_th()

	#MILLIONS
	elif len(str(number)) == 7:
		decode_millions()

	#DEFAULT
	else:
		print "e"


#INPUTS / MAIN CALL
number = int(raw_input("What number would you like to spell? >"))

ones = ["one", "two", "three", "four", "five", "six", "seven", "eight", "nine"]
teens = ["ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"]
tens = ["twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"]
hundreds = ["hundred", "thousand", "million"]

mainFunction()