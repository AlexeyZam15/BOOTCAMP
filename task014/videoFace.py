import cv2

# Подключение распознования лиц
face_cascades = cv2.CascadeClassifier(
    cv2.data.haarcascades + "haarcascade_frontalface_default.xml")

# Передача видео с вебкамеры
cap = cv2.VideoCapture(0)

while True:
    _, frame = cap.read()

# Конвертация в чёрно-белый
    img_gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
# Применение распознования лиц 
    faces = face_cascades.detectMultiScale(img_gray)

    for (x, y, w, h) in faces:
        cv2.rectangle(frame, (x, y), (x + w, y + h), (255,0,255), 2)
    
    cv2.imshow('Result', frame)

# выходит из бесконечного цикла при нажатии клавиши q
    if cv2.waitKey(1) & 0xff == ord('q'):
        break
