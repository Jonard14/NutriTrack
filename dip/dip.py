# import opencv
import cv2

# Load the input image
image = cv2.imread('C:/Users/Geico/AppData/Local/Programs/Python/Python313/lebronjames.jpg')

cv2.imshow('Original', image)
cv2.waitKey(0)
# Use the cvtColor() function to grayscale the image
gray_image = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
blurred_image = cv2.GaussianBlur(gray_image, (3,3),0)

edges = cv2.Canny(blurred_image, 70, 135)

cv2.imshow('Grayscale + Gaussian Blur', blurred_image)
cv2.waitKey(0)

cv2.imshow('Edge Detection', edges)
cv2.waitKey(0)  

# Window shown waits for any key pressing event
cv2.destroyAllWindows()
