from random import randint

print "***************************************************"
print "Welcome to Dice War!"
print "A Heroic Six Dice Game of Death and Epic Struggle!"
print "***************************************************"
print " "

#available die (by no. of sides)
p1Available = [4, 6, 8, 10, 12, 20]
p2Available = [4, 6, 8, 10, 12, 20]

#establish player class
class Player:
	
	def __init__(self, name):
		self.name = name
		self.dice = [4, 6, 8, 10, 12, 20]
		self.dieSelection = 0
		self.currentRoll = 0
		self.roundPoints = 0
		self.roundWins = 0
		
	#def removedDice():
	
	#def dieSelection():
	
	
		
def getInput(playersList):
	while len(playersList) < 2:
		input = raw_input("Player enter your name >")
		playersList.append(input)

def inputToObjects(playersList, playerObjects):
	for name in playersList:
		player = Player(name)
		playerObjects.append(player)

def mainFunction():
	playersList = []
	playerObjects = []

	#take in player names
	getInput(playersList)

	#convert player name inputs to objects
	inputToObjects(playersList, playerObjects)

	for i in playerObjects:
		print i.name
		print i.dice
		
mainFunction()