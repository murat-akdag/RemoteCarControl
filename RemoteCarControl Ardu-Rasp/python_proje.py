import socket
import RPi.GPIO as GPIO
import time
host = "192.168.22.103"
port = 8084
buf = 1024
calistir = (host,port)
GPIO.setwarnings(False)
bagla = socket.socket(socket.AF_INET,socket.SOCK_STREAM)
bagla.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
bagla.bind(calistir)
bagla.listen(1)
GPIO.setmode(GPIO.BCM)
GPIO.setup(2,GPIO.OUT)
GPIO.setup(3,GPIO.OUT)
GPIO.setup(4,GPIO.OUT)


sunucu,adres = bagla.accept()

while True:
   try: 
    veri = sunucu.recv(buf)
    if veri!="":
        if veri== "a":
            print "ileri"
            GPIO.output(2,False)
            GPIO.output(3,False)
            GPIO.output(4,True)
            
            
        elif veri=="b":
            print "geri"
            GPIO.output(2,False)
            GPIO.output(3,True)
            GPIO.output(4,True)
            

        elif veri=="c":
            print "sag"
            GPIO.output(2,True)
            GPIO.output(3,False)
            GPIO.output(4,False)
            
      
        elif veri=="d":
            print "sol"
            GPIO.output(2,False)
            GPIO.output(3,True)
            GPIO.output(4,False)
            
           
        elif veri=="e":
            print "don"

        elif veri=="s":
            print "dur"
            GPIO.output(2,False)
            GPIO.output(3,False)
            GPIO.output(4,False)

        elif veri=="f":
            print "oto"
            GPIO.output(2,False)
            GPIO.output(3,False)
            GPIO.output(4,True)
            time.sleep(7)
            GPIO.output(2,False)
            GPIO.output(3,True)
            GPIO.output(4,False)
            time.sleep(1.9)
            GPIO.output(2,False)
            GPIO.output(3,False)
            GPIO.output(4,False)
            time.sleep(2)
            GPIO.output(2,False)
            GPIO.output(3,False)
            GPIO.output(4,True)
            time.sleep(3)
            GPIO.output(2,False)
            GPIO.output(3,True)
            GPIO.output(4,False)
            time.sleep(1.9)
            GPIO.output(2,False)
            GPIO.output(3,False)
            GPIO.output(4,False)
            time.sleep(2)
            GPIO.output(2,False)
            GPIO.output(3,False)
            GPIO.output(4,True)
            time.sleep(7)
            GPIO.output(2,False)
            GPIO.output(3,True)
            GPIO.output(4,False)
            time.sleep(1.9)
            GPIO.output(2,False)
            GPIO.output(3,False)
            GPIO.output(4,False)
            time.sleep(2)
            GPIO.output(2,False)
            GPIO.output(3,False)
            GPIO.output(4,True)
            time.sleep(3)
            GPIO.output(2,False)
            GPIO.output(3,True)
            GPIO.output(4,False)
            time.sleep(1.9)
            GPIO.output(2,False)
            GPIO.output(3,False)
            GPIO.output(4,False)
            time.sleep(2)
            
   except KeyboardInterrupt:
      if sunucu:
        sunucu.close()
        bagla.close
        print "kapandi"
        break
