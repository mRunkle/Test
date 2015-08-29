import sys, pygame
pygame.init()

def rot_center_transform(image, center):
    oldZero = image.get_rect().center
    imageRotated = pygame.transform.rotate(image, center[2])
    newZero = imageRotated.get_rect().center
    newRect = imageRotated.get_rect()
    newRect.center = (center[0], center[1])
    return imageRotated, newRect

#When you call it from main:
ship = pygame.image.load("ship_0.png")
XPos = 10
YPos = 10
Angle = 0
newCenter = (int(XPos), int(YPos), int(Angle))
newImage, newRect = rot_center_transform(ship, newCenter)


#screen.blit(background, backpos)
screen.blit(newImage, newRect)
#pygame.display.flip()