import os, sys, random, math
import pygame

pygame.init()

height = 800
width = 800
size = (width, height) #here I am setting the size of the window

black = (0, 0, 0)
white = (255, 255, 255)
#create a clock and a gameover variable
clock = pygame.time.Clock()
game_over = False #conditional that determines if game is playing

asteroid_list = [] #list where my astroid objects are stored
screen = pygame.display.set_mode(size)#this creates the window with the size specified
pygame.display.set_caption("Asteroids Errywhere")#sets the display to show the string
background = pygame.image.load("StarField.gif").convert() #sets background

##Use Trigonometry to make this easier
class Asteroid(pygame.sprite.Sprite):
    def __init__(self):
        pygame.sprite.Sprite.__init__(self)
        self.x_axis = 1 #cosine runs paralell to the x-axis
        self.y_axis = 1 #sine runs paralell to the y-axis
        self.angle = random.randint(0, 360) #angle of rotation randomly selected 
        self.angluar_momentum = 1 #amount of energy the asteroid has
        self.image = pygame.image.load("Asteroid.gif").convert() #just the image of the asteroids
        #self.num_of_asteroids = 0
        self.rect = self.image.get_rect()#forms a rectangle for collision detection, if boxes touch they collide
        return

    def get_location(self):
    	return (self.x_axis, self.y_axis)

    def movement(self):
    	self.x_axis += self.angluar_momentum * math.cos(math.radians(self.angle))#uses trig functions to derive the proper
    	self.y_axis -= self.angluar_momentum * math.sin(math.radians(self.angle))#movement along a 2D plane for the asteroid
    	if self.x_axis > 800: #if x axis is greater than screen size then adjust the x axis
    		self.x_axis = self.x_axis - 800
    	if self.x_axis < 0:
    		self.x_axis = self.x_axis + 800
    	if self.y_axis > 800: #if y axis is greater than screen size then adjust the y axis
    		self.y_axis = self.y_axis - 800
    	if self.y_axis < 0:
    		self.y_axis = self.y_axis + 800
    	return


def spawn_asteroids():
	screen.blit(background, (0,0))
	for lone_asteroid in range(10):
		lone_asteroid = Asteroid()
		asteroid_list.append(lone_asteroid)

	while game_over == False:
		for event in pygame.event.get():
			if event.type == pygame.QUIT:
				sys.exit()

		screen.fill(white) #has to be outside the foor loop or only one asteroid will appear!		
		for lone_asteroid in asteroid_list:
			asteroid_position = lone_asteroid.get_location()
			screen.blit(lone_asteroid.image, asteroid_position)
			lone_asteroid.movement()
			#screen.blit(lone_asteroid.image, asteroid_position)
		#if pygame.sprite.spritecollide(lone_asteroid, lone_asteroid, lone_asteroid):#this is for collision detection
		#	print "You had an accident"
		#	continue

		pygame.display.update()
		pygame.time.delay(100)

spawn_asteroids()
# http://stackoverflow.com/questions/8195649/python-pygame-collision-detection-with-rects?rq=1