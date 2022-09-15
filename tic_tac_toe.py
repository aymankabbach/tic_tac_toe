from tkinter import *
from tkinter import messagebox
window = Tk()
window.title("Tic tac toe")
winner=False
clicked= True
click_number=0
buttons_list=[]
def play(Button):
    global clicked,click_number
    if Button["text"]== " " and clicked ==True :
            Button["text"] = "X"
            click_number+=1
            clicked =False
            check_win()
    if Button["text"]== " " and clicked ==False :
            Button["text"] = "O"
            click_number+=1
            clicked =True
            check_win()
def reset():
    global clicked,buttons_list,click_number
    for button in buttons_list[:-1]:
        button["text"]=" "
    clicked=True
    click_number=0
def create_buttons_list():
    global replay_button
    a=Button(window, text=" ", height=4, width=8,bg='#BEB8B7', fg="black", command=lambda: play(a))
    b=Button(window, text=" ", height=4, width=8,bg='#BEB8B7', fg="black", command=lambda: play(b))
    c=Button(window, text=" ", height=4, width=8,bg='#BEB8B7', fg="black", command=lambda: play(c))
    d=Button(window, text=" ", height=4, width=8,bg='#BEB8B7', fg="black", command=lambda: play(d))
    e=Button(window, text=" ", height=4, width=8,bg='#BEB8B7', fg="black", command=lambda: play(e))
    f=Button(window, text=" ", height=4, width=8,bg='#BEB8B7', fg="black", command=lambda: play(f))
    g=Button(window, text=" ", height=4, width=8,bg='#BEB8B7', fg="black", command=lambda: play(g))
    h=Button(window, text=" ", height=4, width=8,bg='#BEB8B7', fg="black", command=lambda: play(h))
    i=Button(window, text=" ", height=4, width=8,bg='#BEB8B7',fg="black", command=lambda: play(i))
    replay_button=Button(window, text="play again", bg='#BEB8B7', fg="black" , command=reset)
    buttons_list.extend([a,b,c,d,e,f,g,h,i,replay_button])
    return buttons_list
def grid_buttons_list():
    buttons_list=create_buttons_list()
    row=0
    column=0
    for button in buttons_list:
        button.grid(row=row,column=column)
        column+=1
        if column==3:
            row+=1
            column=0
        if row==3:
            column+=1
def announce_winner(player):
    messagebox.showinfo("info",f"{player} wins")
def announce_game_over():
    messagebox.showinfo("info","game over")
def check_win():
    global winner,buttons_list
    ##winning cases for X
    if buttons_list[0]["text"] ==buttons_list[1]["text"]==buttons_list[2]["text"]=="X":
        winner=True
        announce_winner("player 1")
    if buttons_list[3]["text"] ==buttons_list[4]["text"] ==buttons_list[5]["text"]=="X":
        winner=True
        announce_winner("player 1")
    if buttons_list[6]["text"] ==buttons_list[7]["text"] ==buttons_list[8]["text"]=="X":
        winner=True
        announce_winner("player 1")
    if buttons_list[0]["text"] ==buttons_list[3]["text"] ==buttons_list[6]["text"]=="X":
        winner=True
        announce_winner("player 1")
    if buttons_list[1]["text"] ==buttons_list[4]["text"] ==buttons_list[7]["text"]=="X":
        winner=True
        announce_winner("player 1")
    if buttons_list[2]["text"] ==buttons_list[5]["text"] ==buttons_list[8]["text"]=="X":
        winner=True
        announce_winner("player 1")
    if buttons_list[0]["text"] ==buttons_list[4]["text"] ==buttons_list[8]["text"]=="X":
        winner=True
        announce_winner("player 1")
    if buttons_list[2]["text"] ==buttons_list[4]["text"] ==buttons_list[6]["text"]=="X":
        winner=True
        announce_winner("player 1")
    #winning cases for O
    if buttons_list[0]["text"] ==buttons_list[1]["text"]==buttons_list[2]["text"]=="O":
        winner=True
        announce_winner("player 2")
    if buttons_list[3]["text"] ==buttons_list[4]["text"] ==buttons_list[5]["text"]=="O":
        winner=True
        announce_winner("player 2")
    if buttons_list[6]["text"] ==buttons_list[7]["text"] ==buttons_list[8]["text"]=="O":
        winner=True
        announce_winner("player 2")
    if buttons_list[0]["text"] ==buttons_list[3]["text"] ==buttons_list[6]["text"]=="O":
        winner=True
        announce_winner("player 2")
    if buttons_list[1]["text"] ==buttons_list[4]["text"] ==buttons_list[7]["text"]=="O":
        winner=True
        announce_winner("player 2")
    if buttons_list[2]["text"] ==buttons_list[5]["text"] ==buttons_list[8]["text"]=="O":
        winner=True
        announce_winner("player 2")
    if buttons_list[0]["text"] ==buttons_list[4]["text"] ==buttons_list[8]["text"]=="O":
        winner=True
        announce_winner("player 2")
    if buttons_list[2]["text"] ==buttons_list[4]["text"] ==buttons_list[6]["text"]=="O":
        winner=True
        announce_winner("player 2")
    elif click_number==9:
        announce_game_over()

grid_buttons_list()
window.mainloop()







