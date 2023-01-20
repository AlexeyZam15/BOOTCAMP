import cv2

face_cascades = cv2.CascadeClassifier(
    cv2.data.haarcascades + "haarcascade_frontalface_default.xml")

img = cv2.imread('face.jpg')
# Конвертация в чёрно-белый
img_gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

faces = face_cascades.detectMultiScale(img_gray)

# for face in faces
for (x, y, w, h) in faces:
    cv2.rectangle(img, (x, y), (x + w, y + h), (255, 0, 255), 2)

cv2.imshow('Result', img)

cv2.waitKey(0)