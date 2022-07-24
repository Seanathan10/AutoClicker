import pyautogui
import time
import numpy as np
import win32api
import win32con
import tkinter as tk
from tkinter import messagebox
import threading
import os

def MouseClick( X, Y ):
    win32api.SetCursorPos( ( X, Y ) )
    win32api.mouse_event( win32con.MOUSEEVENTF_LEFTDOWN, 0, 0 )
    time.sleep( np.random.uniform( 0.1, 0.3 ) )
    win32api.mouse_event( win32con.MOUSEEVENTF_LEFTUP, 0, 0 )


global ScanNumber
global TotalClicks

ScanNumber = 1
TotalClicks = 0


def StartButtonFunction():
    global ScanNumber

    try:
        CheckPictureOnScreen( FileNameBox.get( "1.0", "end-1c" ) )
    except IOError:
        tk.messagebox.showwarning(
            title="Error",
            message="File not found"
        )
        os._exit( 1 )

    threading.Timer( 5.0, StartButtonFunction ).start()
    print( f"Scan { ScanNumber } started [5 second interval]" )
    ScanNumber += 1


def StopButtonFunction():
    print( "=== Mainloop end ===" )
    print( "Closed" )
    # exit( 0 )
    # noinspection PyUnresolvedReferences
    os._exit( 1 )


def CheckPictureOnScreen( PathToPicture ):
    global TotalClicks
    # noinspection PyGlobalUndefined
    global Location
    Location = pyautogui.locateOnScreen( PathToPicture, grayscale=False, confidence=0.9 )

    if Location != None:
        ClickPoint = pyautogui.center(Location)

        PointX = ClickPoint.x
        PointY = ClickPoint.y

        LabelX['text'] = f"X Point: {PointX}"
        LabelY['text'] = f"Y Point: {PointY}"

        MouseClick( PointX, PointY )
        TotalClicks += 1

        print( f"Clicked, #{ TotalClicks }" )


if __name__ == '__main__':
    Root = tk.Tk()

    print( "Built root window" )

    Root.geometry( "650x160" )
    Root.resizable( height=None, width=None )
    Root.attributes( '-topmost', True )
    # MainFrame = tk.Frame( master=Root )

    LabelX = tk.Label(
        master=Root,
        text="X Point: []"
    )#.grid( column=0, row=0 )

    LabelY = tk.Label(
        master=Root,
        text="Y Point: []"
    )#.grid( column=0, row=0 )

    LabelTime = tk.Label(
        master=Root,
        text="Scans every 5 seconds [ see Python console by running through command line or IDLE ]"
    )

    FileNameBox = tk.Text(
        master=Root,
        height=1,
        width=25
    )

    FileNameLabel = tk.Label(
        master=Root,
        text="Enter filename below (place in same folder as this program, include extension (e.g. \"Test.png\") without quotes )"
    )

    StartButton = tk.Button(
        master=Root,
        text="START",
        command=StartButtonFunction
    )

    StopButton = tk.Button(
        master=Root,
        text="EXIT",
        command=StopButtonFunction
    )

    LabelX.pack()
    LabelY.pack()
    LabelTime.pack()
    FileNameLabel.pack()
    FileNameBox.pack()
    StartButton.pack()
    StopButton.pack()

    print( "Window components built" )

    print( "=== Mainloop begin ===" )

    Root.mainloop()


# print( ClickPoint )
# print( ClickPoint[0] )
# print( ClickPoint[1] )
# Point(x=1702, y=112)
# 1702
# 112

'''
print(Location)
print(Location[0])
print(Location[1])
print(Location[2])
print(Location[3])

Box(left=1685, top=99, width=34, height=27)
1685
99
34
27
'''