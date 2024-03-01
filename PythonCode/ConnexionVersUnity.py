import socket
import cv2
from cvzone.HandTrackingModule import  HandDetector
import numpy as np
import math
import time
import os

def connexion():
    server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

    server_socket.bind(('localhost', 5050))

    server_socket.listen(1)

    print("Python: Waiting for Unity to connect...")

    client_socket, addr = server_socket.accept()
    print(f"Python: Unity connected from {addr}")

    data_to_send = "Hello Unity! This is from Python."
    client_socket.sendall(data_to_send.encode())

    client_socket.close()
    server_socket.close()


