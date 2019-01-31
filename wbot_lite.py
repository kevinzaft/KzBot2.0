import numpy as np 
from PIL import ImageGrab
import cv2
import pyautogui
import time
import datetime
import random

#Whats removed:
# 1) Secret tech to detect screen idleness to turn off bot.
# 2) Auto Emote after capture.

# Change your screen coord area here. 
# Use super zoomed out browser for best effect
def grab_screen(gameCoords=(0, 300, 650, 1000)):
	screen = np.array(ImageGrab.grab(bbox=gameCoords))
	screen = cv2.cvtColor(screen, cv2.COLOR_BGR2GRAY)
	screen = cv2.resize(screen,None,fx=1/ir_factor,fy=1/ir_factor)
	return screen

def load_image(img_name):
	img = cv2.imread(img_name)
	img = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
	img = cv2.resize(img,None,fx=1/ir_factor,fy=1/ir_factor)
	return img

# Higher image reduction makes program run faster. 
# Increase if having trouble detecting images on current zoom.
ir_factor = 4
#Take full body images and put them in ./images/ and add their name here.
img_names = ['shiro.png', 'pico.png', 'joey.png']

imgs = {}
for img_name in img_names:
	imgs[img_name] = load_image('./images/' + img_name)

while True:
	try:
		screen = grab_screen()
	except:
		continue

	for img_name, img in imgs.items():
		res = cv2.matchTemplate(screen, img, cv2.TM_SQDIFF_NORMED)
		min_val, _, min_loc, _ = cv2.minMaxLoc(res)
		print(img_name, min_val)
		if min_val < 0.03:
			# Tune this yourself. For some reason not 1-to-1 with desktop size.
			# I'm currently debugging this.
			image_offset = 510
			pyautogui.click(min_loc[0]*ir_factor+5, \
								min_loc[1]*ir_factor+image_offset)
			pyautogui.click(min_loc[0]*ir_factor+5, \
								min_loc[1]*ir_factor+image_offset+20)
			
			# Only focuses on the detected image for the next 10 clicks.
			for i in range (10):
				screen = grab_screen()
				res = cv2.matchTemplate(screen, img, cv2.TM_SQDIFF_NORMED)
				min_val, _, min_loc, _ = cv2.minMaxLoc(res)
				pyautogui.click(min_loc[0]*ir_factor+5, \
								min_loc[1]*ir_factor+image_offset)
				pyautogui.click(min_loc[0]*ir_factor+5, \
									min_loc[1]*ir_factor+image_offset+20)
				# Delay factor between clicks. 
				time.sleep(0.15)
print('Done')
