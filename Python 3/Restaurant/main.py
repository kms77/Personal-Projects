import tkinter as tk
from tkinter.filedialog import *
import tkinter.messagebox
gui = tk.Tk()
gui.geometry("250x100")
gui['background']= '#D2691E'
title_label = tk.Label(gui, text ="Login")
title_label.config(font =("Courier", 14))
title_label.grid()
name_of_a_variable = tk.StringVar()
password_variable = tk.StringVar()
def submit():
    name = name_entry.get()
    password = password_variable.get()

    print("Name: " + name)
    print("Password: " + password)

    name_of_a_variable.set("")
    password_variable.set("")
name_label = tk.Label(gui, text='Username',
                      font=('calibre',
                            10, 'bold'))
name_entry = tk.Entry(gui,
                      textvariable=name_of_a_variable, font = ('calibre', 10, 'normal'))
password_label = tk.Label(gui,
                          text='Password',
                          font=('calibre', 10, 'bold'))
password_entry = tk.Entry(gui,
                          textvariable=password_variable,
                          font=('calibre', 10, 'normal'),
                          show='*')

submit_button = tk.Button(gui, text='Submit',
                          command=submit)
name_label.grid(row=1, column=0)
name_entry.grid(row=1, column=1)
password_label.grid(row=2, column=0)
password_entry.grid(row=2, column=1)
submit_button.grid(row=3, column=1)
gui.mainloop()