import random
import pygame
import sys
from pygame.locals import *

pygame.init()
fps = 30
dispWidth = 800
dispHeight = 600
cellSize = 10

black = (0,0,0)
white = (255,255,255)
bg = black

UP = 'up'
DOWN = 'down'
LEFT = 'left'
RIGHT = 'right'

def whatNext():
    for event in pygame.event.get([KEYDOWN, KEYUP, QUIT]):
        if event.type == QUIT
            pygame.quit()
            sys.exit()
        elif event.type == KEYDOWN:
            continue
        return event.key
    return None




def msgSurface(text, textColor):
    smallText = pygame.font.Font("freesansbold.ttf", 20)
    largeText = pygame.font.Font("freesansbold.ttf", 150)

    titleTextSurf, titleTextRect = makeTextObjs(text, largeText, textColor)
    titleTextRect.center = (int(dispWidth/2), int(dispHeight/2))
    setDisplay.blit(titleTextSurf, titleTextRect)

    typTextSurf, typTextRect = makeTextObjs("Press Key to Continue", smallText, white)
    typTextRect.center = (int(dispWidth/2), int(dispHeight/2) + 120)
    setDisplay.blit(typTextSurf, typTextRect)
    pygame.display.update()
    fpsTime.tick()

    while whatNext() == None:
        for event in pygame.event.get([QUIT]):
            if event.type == QUIT:
                pygame.quit()
                sys.exit()

        pygame.display.update()
        fpsTime.tick()



def runGame():
    startx = 3
    starty = 3
    coords = [{'x': startx,'y': starty}]
    direction = RIGHT

    isAlive = "yes"

    while True: # main game loop

        while isAlive == "yes":

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

            if (newCell["x"] < 0 or newCell["y"] < 0 or newCell["x"] > dispWidth/cellSize or newCell["y"] > dispHeight/cellSize):
                isAlive = "no"

        msgSurface("Game Over", red)


def drawCell(coords):
    for coord in coords:
        x = coord['x'] * cellSize
        y = coord['y'] * cellSize
        makeCell = pygame.Rect(x, y, cellSize, cellSize)
        pygame.draw.rect(setDisplay, white, makeCell)

while True:
    global fpsTime, setDisplay
    
    fpsTime = pygame.time.Clock()
    setDisplay = pygame.display.set_mode((dispWidth, dispHeight))
    pygame.display.set_caption('controlling')
    runGame()