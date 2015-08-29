#establish player class
class Player:
	
	def __init__(self, name):
		self.name = name
		self.availableDice = [4, 6, 8, 10, 12, 20]
		self.dieSelection = 0
		self.currentRoll = 0
		self.roundPoints = 0
		self.roundWins = 0
		
	#dieSelection method
	def changeDieSelection():
			
		
	#def removeDice():
		
	#def changePoints():
		
	#def changeWins():
		
#get number of players
def numPlayers():
    input = raw_input("Enter number of players >")
    input = int(input)
    return input

#get player names
def getNames(i):
	playersList = []
	while len(playersList) < i:
		input = raw_input("Player enter your name >")
		playersList.append(input)
	return playersList
	
#use playersList to create objects
def convertToObjects(pL):
	playerObjects = []
	for i in pL:
		player = Player(i)
		playerObjects.append(player)
	return playerObjects

#players select die to play
def choseDie(pO):
	dieSelections = []
	for i in pO:
		print i.availableDice
		selection = raw_input("Player select which die to play >")
		selection = int(selection)
		dieSelections.append(selection)
	return dieSelections
	
#use dieSelections list to assign dieSelections to player objects
def dieAssign(dS):
	for i in dS:
		#call changeDieSelection method
	
#RUN (mainFunction)
def mainFunction():
	
    #get number of players
	totalPlayers = numPlayers()
	    
	#get player names
	playerNames = getNames(totalPlayers)
		
	#create player objects by feeding in "playerNames"
	playerObjects = convertToObjects(playerNames)
	##for i in playerObjects:
	##	print i.name

	#players select die
	selectedDie = choseDie(playerObjects)
	print selectedDie
	
	#assign die selections to class attribute
	Player.changeDieSelection()
	
	
	dieObjects = dieAssign(selectedDie)
	for i in playerObjects:
		print i.dieSelection
		
	
		
mainFunction()