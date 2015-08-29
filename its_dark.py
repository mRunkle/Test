'''
integer = 435000
mapped = map(int, str(integer))

print mapped

ones = {}
'''
'''
def split_by_n(seq, n):
    seq = str(seq)
    while seq:
        sqYield = yield int(seq[:n])
        seq = seq[n:]
        
sL = list(split_by_n(1231231234, 3))
print sL
'''



import time

#FUNCTIONS
def get_Time():
	t = time.ctime()
	timeSplit = t.split(" ")
	TOD = timeSplit[3]
	timeList = TOD.split(":")
	#print timeList
	return timeList

def split_sunRise(sunRise):
	s_rSplit = sunRise.split(":")
	return s_rSplit

def split_sunSet(sunSet):
	s_sSplit = sunSet.split(":")
	return s_sSplit



sunRise = raw_input("What time does the sun rise today (military time HH:MM:SS >")
sunSet = raw_input("What time does the sun set today (military time HH:MM:SS >")

time = get_Time()
print time
print type(time)

sunRise_split = split_sunRise(sunRise)
print sunRise_split
print type(sunRise_split)

sunSet_split = split_sunSet(sunSet)
print sunSet_split
print type(sunSet_split)

if int(time[0]) > int(sunRise_split[0]) and int(time[0]) < int(sunSet_split[0]):
	print "It's light!"
else:
	int(time[0]) < int(sunRise_split[0]) and int(time[0]) > int(sunSet_split[0])
	print "It's dark."


