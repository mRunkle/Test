from random import randint

print "***************************************************"
print "Welcome to Dice War!"
print "A Heroic Six Dice Game of Death and Epic Struggle!"
print "***************************************************"
print " "

#store number of sides per dice
player1DiceSides = [4, 6, 8, 10, 12, 20]
player2DiceSides = [4, 6, 8, 10, 12, 20]

#random die roll functions
def roll_4():
	rolled4 = randint(1,4)
	return rolled4
def roll_6():
	rolled6 = randint(1,6)
	return rolled6
def roll_8():
	rolled8 = randint(1,8)
	return rolled8
def roll_10():
	rolled10 = randint(1,10)
	return rolled10
def roll_12():
	rolled12 = randint(1,12)
	return rolled12
def roll_20():
	rolled20 = randint(1,20)
	return rolled20
	

#take in player names
playersList = []
while len(playersList) < 2:
	player = raw_input("Player enter your name >")
	playersList.append(player)
print " "

#announce Prepare for War!
print playersList[0] + " & " + playersList[1] + ":",
print "Prepare for War!"
print " "

#ROUND 1
#take in die selections
print "ROUND 1"

dieChoices = []
print playersList[0] + ", select which die to play: " + str(player1DiceSides),
player1Die = raw_input()
player1Die = int(player1Die)
dieChoices.append(player1Die)
player1DiceSides.remove(player1Die)

print playersList[1] + ", select which die to play: " + str(player2DiceSides),
player2Die = raw_input()
player2Die = int(player2Die)
dieChoices.append(player2Die)
player2DiceSides.remove(player2Die)
print " "

#display player rolls
def player1Roll():
	if dieChoices[0] == 4:
		return roll_4()
	elif dieChoices[0] == 6:
		return roll_6()
	elif dieChoices[0] == 8:
		return roll_8()
	elif dieChoices[0] == 10:
		return roll_10()
	elif dieChoices[0] == 12:
		return roll_12()
	elif dieChoices[0] == 20:
		return roll_20()

def player2Roll():
	if dieChoices[1] == 4:
		return roll_4()
	elif dieChoices[1] == 6:
		return roll_6()
	elif dieChoices[1] == 8:
		return roll_8()
	elif dieChoices[1] == 10:
		return roll_10()
	elif dieChoices[1] == 12:
		return roll_12()
	elif dieChoices[1] == 20:
		return roll_20()
		
print playersList[0] + " rolled >",
print player1Roll()

print playersList[1] + " rolled >",
print player2Roll()
print " "

#evaluate die rolls for basic win loss
if player1Roll() > player2Roll():
	print playersList[0] + " Wins the Battle!"
else:
	print playersList[1] + " Wins the Battle!"
print " "

#print four4Roll()

#ROUND 2
#take in die selections
print "ROUND 2"
dieChoices = []
print playersList[0] + ", select which die to play: " + str(player1DiceSides),
player1Die = raw_input()
player1Die = int(player1Die)
dieChoices.append(player1Die)
player1DiceSides.remove(player1Die)

print playersList[1] + ", select which die to play: " + str(player2DiceSides),
player2Die = raw_input()
player2Die = int(player2Die)
dieChoices.append(player2Die)
player2DiceSides.remove(player2Die)
print " "

#display player rolls
def player1Roll():
	if dieChoices[0] == 4:
		return roll_4()
	elif dieChoices[0] == 6:
		return roll_6()
	elif dieChoices[0] == 8:
		return roll_8()
	elif dieChoices[0] == 10:
		return roll_10()
	elif dieChoices[0] == 12:
		return roll_12()
	elif dieChoices[0] == 20:
		return roll_20()

def player2Roll():
	if dieChoices[1] == 4:
		return roll_4()
	elif dieChoices[1] == 6:
		return roll_6()
	elif dieChoices[1] == 8:
		return roll_8()
	elif dieChoices[1] == 10:
		return roll_10()
	elif dieChoices[1] == 12:
		return roll_12()
	elif dieChoices[1] == 20:
		return roll_20()

print playersList[0] + " rolled >",
print player1Roll()

print playersList[1] + " rolled >",
print player2Roll()
print " "

#evaluate die rolls for scoring
if player1Roll() > player2Roll():
	print playersList[0] + " Wins the Battle!"
else:
	print playersList[1] + " Wins the Battle!"
print " "

#ROUND 3
#take in die selections
print "ROUND 3"
dieChoices = []
print playersList[0] + ", select which die to play: " + str(player1DiceSides),
player1Die = raw_input()
player1Die = int(player1Die)
dieChoices.append(player1Die)
player1DiceSides.remove(player1Die)

print playersList[1] + ", select which die to play: " + str(player2DiceSides),
player2Die = raw_input()
player2Die = int(player2Die)
dieChoices.append(player2Die)
player2DiceSides.remove(player2Die)
print " "

#display player rolls
def player1Roll():
	if dieChoices[0] == 4:
		return roll_4()
	elif dieChoices[0] == 6:
		return roll_6()
	elif dieChoices[0] == 8:
		return roll_8()
	elif dieChoices[0] == 10:
		return roll_10()
	elif dieChoices[0] == 12:
		return roll_12()
	elif dieChoices[0] == 20:
		return roll_20()

def player2Roll():
	if dieChoices[1] == 4:
		return roll_4()
	elif dieChoices[1] == 6:
		return roll_6()
	elif dieChoices[1] == 8:
		return roll_8()
	elif dieChoices[1] == 10:
		return roll_10()
	elif dieChoices[1] == 12:
		return roll_12()
	elif dieChoices[1] == 20:
		return roll_20()

print playersList[0] + " rolled >",
print player1Roll()

print playersList[1] + " rolled >",
print player2Roll()
print " "

#evaluate die rolls for scoring
if player1Roll() > player2Roll():
	print playersList[0] + " Wins the Battle!"
else:
	print playersList[1] + " Wins the Battle!"
print " "
	
#ROUND 4
#take in die selections
print "ROUND 4"
dieChoices = []
print playersList[0] + ", select which die to play: " + str(player1DiceSides),
player1Die = raw_input()
player1Die = int(player1Die)
dieChoices.append(player1Die)
player1DiceSides.remove(player1Die)

print playersList[1] + ", select which die to play: " + str(player2DiceSides),
player2Die = raw_input()
player2Die = int(player2Die)
dieChoices.append(player2Die)
player2DiceSides.remove(player2Die)
print " "

#display player rolls
def player1Roll():
	if dieChoices[0] == 4:
		return roll_4()
	elif dieChoices[0] == 6:
		return roll_6()
	elif dieChoices[0] == 8:
		return roll_8()
	elif dieChoices[0] == 10:
		return roll_10()
	elif dieChoices[0] == 12:
		return roll_12()
	elif dieChoices[0] == 20:
		return roll_20()

def player2Roll():
	if dieChoices[1] == 4:
		return roll_4()
	elif dieChoices[1] == 6:
		return roll_6()
	elif dieChoices[1] == 8:
		return roll_8()
	elif dieChoices[1] == 10:
		return roll_10()
	elif dieChoices[1] == 12:
		return roll_12()
	elif dieChoices[1] == 20:
		return roll_20()

print playersList[0] + " rolled >",
print player1Roll()

print playersList[1] + " rolled >",
print player2Roll()
print " "

#evaluate die rolls for scoring
if player1Roll() > player2Roll():
	print playersList[0] + " Wins the Battle!"
else:
	print playersList[1] + " Wins the Battle!"
print " "
	
#ROUND 5
#take in die selections
print "ROUND 5"
dieChoices = []
print playersList[0] + ", select which die to play: " + str(player1DiceSides),
player1Die = raw_input()
player1Die = int(player1Die)
dieChoices.append(player1Die)
player1DiceSides.remove(player1Die)

print playersList[1] + ", select which die to play: " + str(player2DiceSides),
player2Die = raw_input()
player2Die = int(player2Die)
dieChoices.append(player2Die)
player2DiceSides.remove(player2Die)
print " "

#display player rolls
def player1Roll():
	if dieChoices[0] == 4:
		return roll_4()
	elif dieChoices[0] == 6:
		return roll_6()
	elif dieChoices[0] == 8:
		return roll_8()
	elif dieChoices[0] == 10:
		return roll_10()
	elif dieChoices[0] == 12:
		return roll_12()
	elif dieChoices[0] == 20:
		return roll_20()

def player2Roll():
	if dieChoices[1] == 4:
		return roll_4()
	elif dieChoices[1] == 6:
		return roll_6()
	elif dieChoices[1] == 8:
		return roll_8()
	elif dieChoices[1] == 10:
		return roll_10()
	elif dieChoices[1] == 12:
		return roll_12()
	elif dieChoices[1] == 20:
		return roll_20()

print playersList[0] + " rolled >",
print player1Roll()

print playersList[1] + " rolled >",
print player2Roll()
print " "

#evaluate die rolls for scoring
if player1Roll() > player2Roll():
	print playersList[0] + " Wins the Battle!"
else:
	print playersList[1] + " Wins the Battle!"
print " "
	
#ROUND 6
#take in die selections
print "ROUND 6"
dieChoices = []
print playersList[0] + ", select which die to play: " + str(player1DiceSides),
player1Die = raw_input()
player1Die = int(player1Die)
dieChoices.append(player1Die)
player1DiceSides.remove(player1Die)

print playersList[1] + ", select which die to play: " + str(player2DiceSides),
player2Die = raw_input()
player2Die = int(player2Die)
dieChoices.append(player2Die)
player2DiceSides.remove(player2Die)
print " "

#display player rolls
def player1Roll():
	if dieChoices[0] == 4:
		return roll_4()
	elif dieChoices[0] == 6:
		return roll_6()
	elif dieChoices[0] == 8:
		return roll_8()
	elif dieChoices[0] == 10:
		return roll_10()
	elif dieChoices[0] == 12:
		return roll_12()
	elif dieChoices[0] == 20:
		return roll_20()

def player2Roll():
	if dieChoices[1] == 4:
		return roll_4()
	elif dieChoices[1] == 6:
		return roll_6()
	elif dieChoices[1] == 8:
		return roll_8()
	elif dieChoices[1] == 10:
		return roll_10()
	elif dieChoices[1] == 12:
		return roll_12()
	elif dieChoices[1] == 20:
		return roll_20()

print playersList[0] + " rolled >",
print player1Roll()

print playersList[1] + " rolled >",
print player2Roll()
print " "

#evaluate die rolls for scoring
if player1Roll() > player2Roll():
	print playersList[0] + " Wins the Battle!"
else:
	print playersList[1] + " Wins the Battle!"
print " "

'''
#scoring methods
cumulativeScore = [0, 0]
def four4Roll ():
	global cumulativeScore
	if player1Die == 4 and player2Die == 4:
		if player1Roll() > player2Roll():
			cumulativeScore[0] = cumulativeScore[0] + 1
		elif player1Roll() < player2Roll():
			cumulativeScore[1] = cumulativeScore[1] + 1
		elif player1Roll() == player2Roll():
			cumulativeScore = cumulativeScore
	return cumulativeScore
'''