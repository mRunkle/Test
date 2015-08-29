import random
import pygame
import sys
from pygame.locals import *

pygame.init()
fps = 30
dispWidth = 800
dispHeight = 600
cellSize = 5

black = (0,0,0)
white = (255,255,255)
bg = pygame.image.load("space_background.bmp")

UP = 'up'
DOWN = 'down'
LEFT = 'left'
RIGHT = 'right'

'''
def runGame():
    startx = 3
    starty = 3
    coords = [{'x': startx,'y': starty}]
    direction = RIGHT
    
    while True: # main game loop
        for event in pygame.event.get(): # event handling loop
            if event.type == QUIT:
                pygame.quit()
                sys.exit()
           
            elif event.type == KEYDOWN:
                if event.key == K_LEFT:
                    direction = LEFT
                elif event.key == K_RIGHT:
                    direction = RIGHT
                elif event.key == K_UP:
                    direction = UP
                elif event.key == K_DOWN:
                    direction = DOWN


        if direction == UP:
            newCell = {'x': coords[0]['x'], 'y': coords[0]['y'] - 1}
        elif direction == DOWN:
            newCell = {'x': coords[0]['x'], 'y': coords[0]['y'] + 1}
        elif direction == LEFT:
            newCell = {'x': coords[0]['x'] - 1, 'y': coords[0]['y']}
        elif direction == RIGHT:
            newCell = {'x': coords[0]['x'] + 1, 'y': coords[0]['y']}
        del coords[-1]
        
        coords.insert(0, newCell)
        setDisplay.fill(bg)
        drawCell(coords)
        pygame.display.update()
        fpsTime.tick(fps)


def drawCell(coords):
    for coord in coords:
        x = coord['x'] * cellSizeS
        y = coord['y'] * cellSize
        makeCell = pygame.Rect(x, y, cellSize, cellSize)
        pygame.draw.rect(setDisplay, white, makeCell)

while True:
    global fpsTime, setDisplay
    
    fpsTime = pygame.time.Clock()
    setDisplay = pygame.display.set_mode((dispWidth, dispHeight))
    pygame.display.set_caption('controlling')
    runGame()
'''












red = (255,0,0)
green = (0,255,0)
blue = (0,0,255)
yellow = (255,255,0)
cyan = (0,255,255)
purple = (255,0,255)

setDisplay = pygame.display.set_mode((300, 300))
pygame.display.set_caption("epic game")

FPS = 30  #Frames Per Second ==> increase to speed up
i = pygame.image.load("ship_0.png")
img = pygame.transform.rotate(i, 180)
imgx = 10
imgy = 10
pixMove = 3  #Corresponding adjustment with FPS will alter speed of game
movement = "down"

fpsTime = pygame.time.Clock()

while True:
	setDisplay.blit(bg, (0,0))

	if movement == "down":
		imgy += pixMove
		if imgy > 200:
			img = pygame.transform.rotate(img, 90)
			movement = "right"

	elif movement == "right":
		imgx += pixMove
		if imgx > 200:
			img = pygame.transform.rotate(img, 90)
			movement = "up"

	elif movement == "up":
		imgy -= pixMove
		if imgy < 30:
			img = pygame.transform.rotate(img, 90)
			movement = "left"
	elif movement == "left":
		imgx -= pixMove
		if imgx < 30:
			img = pygame.transform.rotate(img, 90)
			movement = "down"

	setDisplay.blit(img, (imgx, imgy))
	for event in pygame.event.get():
		#print event
		if event.type == QUIT:
			pygame.quit()
			sys.exit()
	
	pygame.display.update()
	fpsTime.tick(FPS)
	