class Player:

	def __init__(self, name):
		self.name = name
		self.health = 100
		self.weapon = ""
		self.powerUpsAvailable = []
		self.consecutiveHits = 0
		
	def changeHealth(self, healthChangeFactor):
		self.health = health - healthChangeFactor
		
	def changeWeapon(self, weaponSelect):
		self.weapon = weaponSelect

class Weapon:

	def __init__(self, weapon):
		self.damage = 0
		self.hitPercent = 0
				
def createCharObjects():
	characterList = [Player("Computer"), Player("Granola Bar"), Player("Notebook"), Player("Backpack")]
	charObjects = []
	for i in characterList:
		char = i
		charObjects.append(char)
	print characterList
	print charObjects

charObjects = createCharObjects()
'''
for i in charObjects:
	print i.name
	
notebookName = charObjects[2].name
print notebookName

weaponSelect = "paperCut"
notebookWeapon = charObjects[2].changeWeapon(weaponSelect)
print charObjects[2].weapon
'''