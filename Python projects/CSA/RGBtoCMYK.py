def RGBtoCMYK(r, g, b):
	rgb = [r, g, b]
	cmyk = [0, 0, 0, 0]

	for i in range(3): # Checks user input
		if (rgb[i] > 255):
			return "Too big a value"
	w = rgb[0]
	for i in range(3): # Determines max
		try:
			if (rgb[i+1] > rgb[i]):
				w = rgb[i+1]
		except IndexError:
			continue
	#print(w) # Debug for max value algo

	cmyk[3] = 1 - w
	for i in range(3): # Converts
		cmyk[i] = 1 - rgb[i] / w; cmyk[i] *= 100

	for x in cmyk:
		print(x)
RGBtoCMYK(45, 156, 5)